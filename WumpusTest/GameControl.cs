using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameControl
    {
        // instance variables
        public GUI _gui;
        private Cave _cave;
        private Room _room;
        private Player _player;
        private Wumpus _wumpus;
        private HazardManager _hazardManager;
        private Trivia _trivia;
        private HighScore _highscore;
        private Secrets _secrets;
        private int turns;
        private int availableCoins;
        private string name;
        private int[] surroundingRooms;
        private int[] availableRooms;
        private string triviaType;
        private int numCorrect;
        private int numQuestions;

        public GameControl(GUI gui)
        {
            _gui              = gui;
            _cave             = new Cave();
            _room             = new Room();
            _player           = new Player();
            _hazardManager    = new HazardManager(_player.getRoomNumber());
            _wumpus           = new Wumpus(_player.getRoomNumber());
            _trivia           = new Trivia();
            _highscore        = new HighScore();
            _secrets          = new Secrets();
            turns             = 0;
            availableCoins    = 90; // not 100 since the player starts with 10 coins
        }

        public void setName(string name)
        {
            this.name = name;
        }

        private void endGame(bool wonGame)
        {
            int score = calculateScore(wonGame);
            _highscore.addScore(name, score);
            if (wonGame)
            { 
                _gui.displayEndScreen(wonGame, score);
            }
            else
            {
                _gui.displayEndScreen(wonGame, score);
            }
        }

        public string[] getHighScores()
        {
            return _highscore.getScores();
        }

        public string[] getNames()
        {
            return _highscore.getNames();
        }

        private int calculateScore(bool wonGame)
        {
            int score = 100 - turns + _player.getCoins() + (5 * _player.getArrows());
            if (wonGame)
            {
                score += 50;
            }
            if (score < 0)
            {
                score = 0;
            }
            return score;
        }

        public int[] roomsEnabled()
        {
            int[] rooms = new int[6];
            for (int i = 0; i < surroundingRooms.Length; i++)
            {
                for (int j = 0; j < availableRooms.Length; j++)
                {
                    if (surroundingRooms[i] == availableRooms[j])
                    {
                        rooms[i] = surroundingRooms[i];
                        break;
                    }
                    else
                    {
                        rooms[i] = -1;
                    }
                }
            }
            return rooms;
        }

        public void initialRoomLoad()
        {
            _room = _cave.getRoombyRoomNumber(_player.getRoomNumber());
            surroundingRooms = _room.getSurrounding();
            availableRooms = _room.getAvailable();
            _gui.setRoomStates(surroundingRooms, roomsEnabled());
            _gui.displayRoomStates(_player.getRoomNumber());
            _gui.displayStatusBarState(_player.getCoins(), _player.getArrows());
            checkAdjacent();
        }

        // called when the player inititates a move to another room, causing a new room to be displayed and coins and turns incremented
        public void moveInitiatedByPlayer(int newRoom)
        {
            // increment number of turns
            turns++;

            // update room state
            moveRoom(newRoom);

            // update player inventory and update on GUI
            if (availableCoins > 0)
            {
                _player.addOneCoin();
                availableCoins--;
            }
            _gui.displayStatusBarState(_player.getCoins(), _player.getArrows());

            // check adjacent rooms for hazards or wumpus and update GUI accordingly
            checkAdjacent();

            /* check and run encounters in new room with hazard or wumpus
               if a hazard and wumpus are both in the room, encounter the wumpus first */
            checkEncounters();
        }

        /* General method to move rooms and can be used by bat hazard, as the player being moved by the 
           bat does not count as a turn and therefore does not require coins or turns to be incremented. Since the bat will not take
           the user to a room occupied by another hazard, no checks for hazards in the new room are necessary*/
        private void moveRoom(int newRoom)
        {
            _player.setRoomNumber(newRoom);
            _room = _cave.getRoombyRoomNumber(newRoom);
            surroundingRooms = _room.getSurrounding();
            availableRooms = _room.getAvailable();
            _gui.setRoomStates(surroundingRooms, roomsEnabled());
            _gui.displayRoomStates(_player.getRoomNumber());
        }

        private void checkAdjacent()
        {
            if (containsRoom(_hazardManager.getPitARoom()) ||  containsRoom(_hazardManager.getPitBRoom()))
            {
                _gui.displayWarning("pit");
            }
            if (containsRoom(_hazardManager.getBatARoom()) || containsRoom(_hazardManager.getBatBRoom()))
            {
                _gui.displayWarning("bats");
            }
            if (containsRoom(_wumpus.getRoom()))
            {
                _gui.displayWarning("wumpus");
            }
        }

        private bool containsRoom(int target)
        {
            foreach (int room in availableRooms)
            {
                if (room == target)
                {
                    return true;
                }
            }
            return false;
        }

        private void checkEncounters()
        {
            if (_player.getRoomNumber() == _wumpus.getRoom())
            {
                runTrivia("wumpus");
            }
            if (_player.getRoomNumber() == _hazardManager.getBatARoom() || _player.getRoomNumber() == _hazardManager.getBatBRoom())
            {
                moveRoom(_hazardManager.carryPlayerToNewRoom(_player.getRoomNumber()));
            }
            if (_player.getRoomNumber() ==_hazardManager.getPitARoom() || _player.getRoomNumber() == _hazardManager.getPitBRoom())
            {
                runTrivia("pit");
            }
        }

        private void runTrivia(string type)
        {
            _gui.displayTrivia();
            triviaType = type;
            numCorrect = 0;
            numQuestions = 0;
            askTriviaQuestion();
        }

        private void askTriviaQuestion()
        {
            _player.spendOneCoin();
            if (!coinsRemaining())
            {
                endGame(false);
            }
            _gui.displayCoins(_player.getCoins());
            string[] question = _trivia.getRandomQuestionGroup();
            _gui.displayTriviaQuestion(question);
        }

        public string getTriviaAnswer()
        {
            return _trivia.getCorrectAnswer();
        }

        public void updateTrivia(bool isCorrect)
        {
            if (isCorrect)
            {
                numCorrect++;
            }
            numQuestions++;
            switch (triviaType)
            {
                case "wumpus":
                    if (numCorrect == 3)
                    {
                        _wumpus.runAwayAfterFight(_player.getRoomNumber());
                        _gui.hideTrivia();
                    }
                    else if (numQuestions < 5)
                    {
                        askTriviaQuestion();
                    }
                    else
                    {
                        endGame(false);
                    }
                    break;
                case "pit":
                    if (numCorrect == 2)
                    {
                        _hazardManager.resetPitRoom(_player.getRoomNumber());
                        _gui.hideTrivia();
                    }
                    else if (numQuestions < 3)
                    {
                        askTriviaQuestion();
                    }
                    else
                    {
                        endGame(false);
                    }
                    break;
                case "arrow":
                    if (numCorrect == 2)
                    {
                        _player.addTwoArrows();
                        _gui.displayArrows(_player.getArrows());
                        _gui.hideTrivia();
                    }
                    else if (numQuestions < 3)
                    {
                        askTriviaQuestion();
                    }
                    else
                    {
                        _gui.hideTrivia();
                    }
                    break;
                case "secret":
                    if (numCorrect == 2)
                    {
                        _gui.displaySecret(getSecret());
                        _gui.hideTrivia();
                    }
                    else if (numQuestions < 3)
                    {
                        askTriviaQuestion();
                    }
                    else
                    {
                        _gui.hideTrivia();
                    }
                    break;
                default:
                    break;
            }
        }

        private bool coinsRemaining()
        {
            return _player.getCoins() != 0;
        }

        private bool arrowsRemaining()
        {
            return _player.getArrows() != 0;
        }

        public void buyArrow()
        {
            turns++;
            runTrivia("arrow");
        }

        public void buySecret()
        {
            turns++;
            runTrivia("secret");
        }

        public string getSecret()
        {
            string secret = _secrets.getRandomSecret();
            switch (secret)
            {
                case "You are in room":
                    secret += " " + _player.getRoomNumber().ToString();
                    break;
                case "Bats are in room":
                    secret += " " + _hazardManager.getBatARoom().ToString();
                    break;
                case "A pit is in room":
                    secret += " " + _hazardManager.getPitARoom().ToString();
                    break;
                case "The wumpus is in room":
                    secret += " " + _wumpus.getRoom().ToString();
                    break;
                default:
                    break;
            }
            return secret;
        }

        public void shootArrow(int roomNum)
        {
            turns++;
            _player.SpendAnArrow();
            _gui.displayArrows(_player.getArrows());
            _wumpus.runAwayAfterArrowShot(_player.getRoomNumber());
            if (roomNum == _wumpus.getRoom())
            {
                _gui.displayArrowResult(true);
                endGame(true);
            }
            else
            {
                _gui.displayArrowResult(false);
                if (!arrowsRemaining())
                {
                    endGame(false);
                }
            }
        }

    }

}
