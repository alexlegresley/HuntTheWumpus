using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{

    public partial class GUI : Form
    {

        // instance variables
        private GameControl _gameControl;
        private HighScore _highScore;
        private int[] surroundingRooms;
        private int[] roomsEnabled;
        private string[] question;

        // initialize form, GameControl object, and make the main menu visible
        public GUI()
        {
            InitializeComponent();
            pnMainMenu.BringToFront();
        }

        // start game
        private void btnStart_Click(object sender, EventArgs e)
        {
            _gameControl = new GameControl(this);
            pnNameInput.BringToFront();
            tbName.Clear();
        }

        // get user name
        private void btnDone_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Length > 0)
            {
                _gameControl.setName(tbName.Text);
            }
            else
            {
                _gameControl.setName("Anonymous");
            }
            initialRoomLoad();
        }

        private void initialRoomLoad()
        {
            _gameControl.initialRoomLoad();
            pnGame.BringToFront();
            pnStatusBar.BringToFront();
            setArrowTargetBackgrounds();
            hideArrowShotDirections();
        }

        private void btnStToMM_Click(object sender, EventArgs e)
        {
            pnMainMenu.BringToFront();
        }


        // show high scores
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            _highScore = new HighScore();
            pnHighScores.BringToFront();
            displayHighScores(_highScore.getScores(), _highScore.getNames());
        }

        private void displayHighScores(string[] scores, string[] names)
        {
            lblScore1.Text = scores[0];
            lblPlayerName1.Text = names[0];
            lblScore2.Text = scores[1];
            lblPlayerName2.Text = names[1];
            lblScore3.Text = scores[2];
            lblPlayerName3.Text = names[2];
            lblScore4.Text = scores[3];
            lblPlayerName4.Text = names[3];
            lblScore5.Text = scores[4];
            lblPlayerName5.Text = names[4];
            lblScore6.Text = scores[5];
            lblPlayerName6.Text = names[5];
            lblScore7.Text = scores[6];
            lblPlayerName7.Text = names[6];
            lblScore8.Text = scores[7];
            lblPlayerName8.Text = names[7];
            lblScore9.Text = scores[8];
            lblPlayerName9.Text = names[8];
            lblScore10.Text = scores[9];
            lblPlayerName10.Text = names[9];
        }

        private void btnHighScoreToMainMenu_Click(object sender, EventArgs e)
        {
            pnMainMenu.BringToFront();
        }

        // show instructions
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            pnInstructions.BringToFront();
            rtbInstructions.Text = Properties.Resources.Instructions;
        }
        private void btnInToMM_Click(object sender, EventArgs e)
        {
            pnMainMenu.BringToFront();
        }

        // for use with displayRoomStates and displayArrowShotDirections
        public void setRoomStates(int[] surroundingRooms, int[] roomsEnabled)
        {
            this.surroundingRooms = surroundingRooms;
            this.roomsEnabled = roomsEnabled;
        }

        public void displayRoomStates(int currentRoom)
        {
            // north room
            if (roomsEnabled[0] != -1)
            {
                pbNorth.BackgroundImage = Properties.Resources.North_Door;
                pbNorth.Enabled = true;
            }
            else
            {
                pbNorth.BackgroundImage = Properties.Resources.North_NoDoor;
                pbNorth.Enabled = false;
            }
            lblNorth.Text = surroundingRooms[0].ToString();

            // northeast room
            if (roomsEnabled[1] != -1)
            {
                pbNortheast.BackgroundImage = Properties.Resources.Northeast_Door;
                pbNortheast.Enabled = true;
            }
            else
            {
                pbNortheast.BackgroundImage = Properties.Resources.Northeast_NoDoor;
                pbNortheast.Enabled = false;
            }
            lblNortheast.Text = surroundingRooms[1].ToString();

            // southeast room
            if (roomsEnabled[2] != -1)
            {
                pbSoutheast.BackgroundImage = Properties.Resources.Southeast_Door;
                pbSoutheast.Enabled = true;
            }
            else
            {
                pbSoutheast.BackgroundImage = Properties.Resources.Southeast_NoDoor;
                pbSoutheast.Enabled = false;
            }
            lblSoutheast.Text = surroundingRooms[2].ToString();

            // south room
            if (roomsEnabled[3] != -1)
            {
                pbSouth.BackgroundImage = Properties.Resources.South_Door;
                pbSouth.Enabled = true;
            }
            else
            {
                pbSouth.BackgroundImage = Properties.Resources.South_NoDoor;
                pbSouth.Enabled = false;
            }
            lblSouth.Text = surroundingRooms[3].ToString();

            // southwest room
            if (roomsEnabled[4] != -1)
            {
                pbSouthwest.BackgroundImage = Properties.Resources.Southwest_Door;
                pbSouthwest.Enabled = true;
            }
            else
            {
                pbSouthwest.BackgroundImage = Properties.Resources.Southwest_NoDoor;
                pbSouthwest.Enabled = false;
            }
            lblSouthwest.Text = surroundingRooms[4].ToString();

            // northwest room
            if (roomsEnabled[5] != -1)
            {
                pbNorthwest.BackgroundImage = Properties.Resources.Northwest_Door;
                pbNorthwest.Enabled = true;
            }
            else
            {
                pbNorthwest.BackgroundImage = Properties.Resources.Northwest_NoDoor;
                pbNorthwest.Enabled = false;
            }
            lblNorthwest.Text = surroundingRooms[5].ToString();

            // show current room number
            lblNumCurrentRoom.Text = currentRoom.ToString();
        }

        private void pbNorth_Click(object sender, EventArgs e)
        {
            _gameControl.moveInitiatedByPlayer(surroundingRooms[0]);
        }

        private void pbNortheast_Click(object sender, EventArgs e)
        {
            _gameControl.moveInitiatedByPlayer(surroundingRooms[1]);
        }

        private void pbSoutheast_Click(object sender, EventArgs e)
        {
            _gameControl.moveInitiatedByPlayer(surroundingRooms[2]);
        }

        private void pbSouth_Click(object sender, EventArgs e)
        {
            _gameControl.moveInitiatedByPlayer(surroundingRooms[3]);
        }

        private void pbSouthwest_Click(object sender, EventArgs e)
        {
            _gameControl.moveInitiatedByPlayer(surroundingRooms[4]);
        }

        private void pbNorthwest_Click(object sender, EventArgs e)
        {
            _gameControl.moveInitiatedByPlayer(surroundingRooms[5]);
        }

        public void displayStatusBarState(int coins, int arrows)
        {
            lblNumCoins.Text = coins.ToString();
            lblNumArrows.Text = arrows.ToString();
            tbWarnings.Clear();
            tbMessages.Clear();
        }

        public void displayCoins(int coins)
        {
            lblNumCoins.Text = coins.ToString();
        }

        private void btnBuyArrow_Click(object sender, EventArgs e)
        {
            _gameControl.buyArrow();
        }

        public void displayArrows(int arrows)
        {
            lblNumArrows.Text = arrows.ToString();
        }

        private void btnBuySecret_Click(object sender, EventArgs e)
        {
            _gameControl.buySecret();
        }

        public void displaySecret(string secret)
        {
            tbMessages.Text = secret;
        }

        private void btnShootArrow_Click(object sender, EventArgs e)
        {
            displayArrowShotDirections();
            btnCancelArrow.Enabled = true;
        }

        private void btnCancelArrow_Click(object sender, EventArgs e)
        {
            hideArrowShotDirections();
            btnCancelArrow.Enabled = false;
        }

        private void setArrowTargetBackgrounds()
        {
            pbArrowNorth.BackColor = Color.Transparent;
            pbArrowNortheast.BackColor = Color.Transparent;
            pbArrowSoutheast.BackColor = Color.Transparent;
            pbArrowSouth.BackColor = Color.Transparent;
            pbArrowSouthwest.BackColor = Color.Transparent;
            pbArrowNorthwest.BackColor = Color.Transparent;
        }

        private void displayArrowShotDirections()
        {
            // north room
            if (roomsEnabled[0] != -1)
            {
                pbArrowNorth.BringToFront();
                pbArrowNorth.Enabled = true;
            }
            else
            {
                pbArrowNorth.SendToBack();
                pbArrowNorth.Enabled = false;
            }

            // northeast room
            if (roomsEnabled[1] != -1)
            {
                pbArrowNortheast.BringToFront();
                pbArrowNortheast.Enabled = true;
            }
            else
            {
                pbArrowNortheast.SendToBack();
                pbArrowNortheast.Enabled = false;
            }

            // southeast room
            if (roomsEnabled[2] != -1)
            {
                pbArrowSoutheast.BringToFront();
                pbArrowSoutheast.Enabled = true;
            }
            else
            {
                pbArrowSoutheast.SendToBack();
                pbArrowSoutheast.Enabled = false;
            }

            // south room
            if (roomsEnabled[3] != -1)
            {
                pbArrowSouth.BringToFront();
                pbArrowSouth.Enabled = true;
            }
            else
            {
                pbArrowSouth.SendToBack();
                pbArrowSouth.Enabled = false;
            }

            // southwest room
            if (roomsEnabled[4] != -1)
            {
                pbArrowSouthwest.BringToFront();
                pbArrowSouthwest.Enabled = true;
            }
            else
            {
                pbArrowSouthwest.SendToBack();
                pbArrowSouthwest.Enabled = false;
            }

            // northwest room
            if (roomsEnabled[5] != -1)
            {
                pbArrowNorthwest.BringToFront();
                pbArrowNorthwest.Enabled = true;
            }
            else
            {
                pbArrowNorthwest.SendToBack();
                pbArrowNorthwest.Enabled = false;
            }
        }

        private void hideArrowShotDirections()
        {
            pbArrowNorth.SendToBack();
            pbArrowNorth.Enabled = false;
            pbArrowNortheast.SendToBack();
            pbArrowNortheast.Enabled = false;
            pbArrowSoutheast.SendToBack();
            pbArrowSoutheast.Enabled = false;
            pbArrowSouth.SendToBack();
            pbArrowSouth.Enabled = false;
            pbArrowSouthwest.SendToBack();
            pbArrowSouthwest.Enabled = false;
            pbArrowNorthwest.SendToBack();
            pbArrowNorthwest.Enabled = false;
        }

        private void pbArrowNorth_Click(object sender, EventArgs e)
        {
            _gameControl.shootArrow(surroundingRooms[0]);
            hideArrowShotDirections();
        }

        private void pbArrowNortheast_Click(object sender, EventArgs e)
        {
            _gameControl.shootArrow(surroundingRooms[1]);
            hideArrowShotDirections();
        }

        private void pbArrowSoutheast_Click(object sender, EventArgs e)
        {
            _gameControl.shootArrow(surroundingRooms[2]);
            hideArrowShotDirections();
        }

        private void pbArrowSouth_Click(object sender, EventArgs e)
        {
            _gameControl.shootArrow(surroundingRooms[3]);
            hideArrowShotDirections();
        }

        private void pbArrowSouthwest_Click(object sender, EventArgs e)
        {
            _gameControl.shootArrow(surroundingRooms[4]);
            hideArrowShotDirections();
        }

        private void pbArrowNorthwest_Click(object sender, EventArgs e)
        {
            _gameControl.shootArrow(surroundingRooms[5]);
            hideArrowShotDirections();
        }

        public void displayArrowResult(bool hit)
        {
            if (hit)
            {
                tbMessages.Text = "Arrow hit!";
            }
            else
            {
                tbMessages.Text = "Arrow missed!";
            }
        }

        public void displayWarning(string type)
        {
            if (type.Equals("pit"))
            {
                tbWarnings.Text = "I feel a draft";
            }
            if (type.Equals("bats"))
            {
                if (tbWarnings.Text == "I feel a draft" || tbWarnings.Text == "Bats nearby" || tbWarnings.Text == "I smell a Wumpus")
                {
                    tbWarnings.Text += ", Bats nearby";
                }
                else
                {
                    tbWarnings.Text = "Bats nearby";
                }
            }
            if (type.Equals("wumpus"))
            {
                if (tbWarnings.Text == "I feel a draft" || tbWarnings.Text == "Bats nearby" || tbWarnings.Text == "I smell a Wumpus")
                {
                    tbWarnings.Text += ", I smell a Wumpus";
                }
                else
                {
                    tbWarnings.Text = "I smell a Wumpus";
                }
            }
        }

        public void displayTrivia()
        {
            pnTrivia.BringToFront();
            btnBuyArrow.Enabled = false;
            btnBuySecret.Enabled = false;
            btnShootArrow.Enabled = false;
        }

        public void hideTrivia()
        {
            pnTrivia.SendToBack();
            btnBuyArrow.Enabled = true;
            btnBuySecret.Enabled = true;
            btnShootArrow.Enabled = true;
        }

        public void displayTriviaQuestion(string[] question)
        {
            // store value to instance variable for use with answer choice buttons
            this.question = question;
            // display question and answers
            tbQuestion.Text = question[0];
            btnAnswer1.Text = question[1];
            btnAnswer2.Text = question[2];
            btnAnswer3.Text = question[3];
            btnAnswer4.Text = question[4];
        }

        private void checkAnswer(string answer)
        {
            bool isCorrect = answer.Equals(_gameControl.getTriviaAnswer());
            _gameControl.updateTrivia(isCorrect);
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            checkAnswer(question[1]);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            checkAnswer(question[2]);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            checkAnswer(question[3]);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            checkAnswer(question[4]);
        }

        public void displayEndScreen(bool wonGame, int score)
        {
            pnEndScreen.BringToFront();
            if (wonGame)
            {
                lblResult.Text = "YOU WON";
            }
            else
            {
                lblResult.Text = "YOU DIED";
            }
            lblNumFinalScore.Text = score.ToString();
        }

        private void btnEndScreenToMainMenu_Click(object sender, EventArgs e)
        {
            pnMainMenu.BringToFront();
        }

    }

}
