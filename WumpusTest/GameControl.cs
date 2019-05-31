using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameControl
    {
        // instance variables
        private GUI _gui;
        private Cave _cave;
        private Room _room;
        private Player _player;
        private Wumpus _wumpus;
        private HazardManager _hazardManager;
        private Trivia _trivia;
        private HighScore _highscore;
        private int turns;
        private int currentRoom;
        private string name;
        private int[] surroundingRooms;
        private int[] availableRooms;

        public GameControl()
        {
        }

        public void beginGame()
        {
            _gui        = new GUI();
            _cave       = new Cave();
            _room       = new Room();
            _player     = new Player();
            _hazardManager = new HazardManager(_player.getRoomNumber());
            _wumpus     = new Wumpus();
            _trivia     = new Trivia();
            _highscore  = new HighScore();
            turns       = 0;
            currentRoom = _player.getRoomNumber();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        private void endGame()
        {
            int score = calculateScore();
            _highscore.rearrangeScores(name, score);
            _gui.displayMainMenu();
        }

        private int calculateScore()
        {
            int score = 100 - turns + _player.getGold() + (5 * _player.getArrows());
            if (!_hazard.wumpusAlive())
            {
                score += 50;
            }
            return score;
        }

        public void movePlayer(int newRoom)
        {
            if (_player.getGold() - 1 > 0)
            {
                _room = _cave.getRoombyRoomNumber(newRoom);
                surroundingRooms = _room.getSurrounding();
                availableRooms = _room.getAvailable();
                _gui.setRoomStates(surroundingRooms, availableRooms);
            }
            else
            {
                endGame();
            }  
        }

        private int convertDirectionToRoom(string direction)
        {

        }


        public void buyArrow()
        {
            if (pc.numCoins > 0)
            {
                t.playTrivia("purchase");
                if (t.isWinner())
                {
                    pc.addArrow();
                    gui.addArrow();
                }
            }
        }

        private void encounterWumpus()
        {
            if (gl.getCurrentRoom() == gl.getWumpusRoom())
            {
                t.playTrivia("wumpus");
                if (t.isWinner())
                {
                    gl.moveWumpus();
                }
                else
                {
                    endGame();
                }
            }
        }

        public void hazardsAdjacent()
        {
            // this method is more or less implemented in HazardManager
            // sends an array of adjacent rooms to game locations and receives whether a hazard is adjacent, and what type
            // calls user interface to display a message for the adjacent hazard
        }

        public void shootArrow()
        {
            _player.SpendAnArrow();
            // call game location with selected room to determine if the Wumpus was in the room to which the arrow was shot
            // if Wumpus is not killed and that was the last arrow, end the game
        }

    }

}
