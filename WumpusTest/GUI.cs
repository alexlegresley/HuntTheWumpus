using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{

    public partial class GUI : Form
    {

        // instance variables
        private GameControl _gameControl;

        // initialize form, GameControl object, and make the main menu visible
        public GUI()
        {
            InitializeComponent();
            pnMainMenu.BringToFront();
        }

        // start game
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnNameInput.BringToFront();
            _gameControl = new GameControl();
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
            pnGame.BringToFront();
            pnStatusBar.BringToFront();
            setArrowTargetBackgrounds();
        }

        private void btnStToMM_Click(object sender, EventArgs e)
        {
            pnMainMenu.BringToFront();
        }


        // show high scores
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            pnHighScores.BringToFront();
            displayHighScores(_gameControl.getHighScores(), _gameControl.getPlayerNames);
        }

        private void displayHighScores(int[] scores, string[] names)
        {
            switch (scores.Length)
            {
                case 1:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    break;
                case 2:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    break;
                case 3:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    break;
                case 4:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    break;
                case 5:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    lblScore5.Text = scores[4].ToString();
                    lblPlayerName5.Text = names[4];
                    break;
                case 6:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    lblScore5.Text = scores[4].ToString();
                    lblPlayerName5.Text = names[4];
                    lblScore6.Text = scores[5].ToString();
                    lblPlayerName6.Text = names[5];
                    break;
                case 7:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    lblScore5.Text = scores[4].ToString();
                    lblPlayerName5.Text = names[4];
                    lblScore6.Text = scores[5].ToString();
                    lblPlayerName6.Text = names[5];
                    lblScore7.Text = scores[6].ToString();
                    lblPlayerName7.Text = names[6];
                    break;
                case 8:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    lblScore5.Text = scores[4].ToString();
                    lblPlayerName5.Text = names[4];
                    lblScore6.Text = scores[5].ToString();
                    lblPlayerName6.Text = names[5];
                    lblScore7.Text = scores[6].ToString();
                    lblPlayerName7.Text = names[6];
                    lblScore8.Text = scores[7].ToString();
                    lblPlayerName8.Text = names[7];
                    break;
                case 9:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    lblScore5.Text = scores[4].ToString();
                    lblPlayerName5.Text = names[4];
                    lblScore6.Text = scores[5].ToString();
                    lblPlayerName6.Text = names[5];
                    lblScore7.Text = scores[6].ToString();
                    lblPlayerName7.Text = names[6];
                    lblScore8.Text = scores[7].ToString();
                    lblPlayerName8.Text = names[7];
                    lblScore9.Text = scores[8].ToString();
                    lblPlayerName9.Text = names[8];
                    break;
                case 10:
                    lblScore1.Text = scores[0].ToString();
                    lblPlayerName1.Text = names[0];
                    lblScore2.Text = scores[1].ToString();
                    lblPlayerName2.Text = names[1];
                    lblScore3.Text = scores[2].ToString();
                    lblPlayerName3.Text = names[2];
                    lblScore4.Text = scores[3].ToString();
                    lblPlayerName4.Text = names[3];
                    lblScore5.Text = scores[4].ToString();
                    lblPlayerName5.Text = names[4];
                    lblScore6.Text = scores[5].ToString();
                    lblPlayerName6.Text = names[5];
                    lblScore7.Text = scores[6].ToString();
                    lblPlayerName7.Text = names[6];
                    lblScore8.Text = scores[7].ToString();
                    lblPlayerName8.Text = names[7];
                    lblScore9.Text = scores[8].ToString();
                    lblPlayerName9.Text = names[8];
                    lblScore10.Text = scores[9].ToString();
                    lblPlayerName10.Text = names[9];
                    break;
                default:
                    break;
            }
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

        public void displayRoomStates(int[] surroundingRooms, int[] availableRooms, int currentRoom)
        {
            // north room
            if (containsRoom(surroundingRooms[0], availableRooms))
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
            if (containsRoom(surroundingRooms[1], availableRooms))
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
            if (containsRoom(surroundingRooms[2], availableRooms))
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
            if (containsRoom(surroundingRooms[3], availableRooms))
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
            if (containsRoom(surroundingRooms[4], availableRooms))
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
            if (containsRoom(surroundingRooms[5], availableRooms))
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

        private bool containsRoom(int target, int[] availableRooms)
        {
            foreach (int room in availableRooms)
            {
                if (target == room)
                {
                    return true;
                }
            }
            return false;
        }

        private void pbNorth_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer("north");
        }

        private void pbNortheast_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer("northeast");
        }

        private void pbSoutheast_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer("southeast");
        }

        private void pbSouth_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer("south");
        }

        private void pbSouthwest_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer("southwest");
        }

        private void pbNorthwest_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer("northwest");
        }

        public void displayStatusBarState(int coins, int arrows)
        {
            lblNumCoins.Text = coins.ToString();
            lblNumArrows.Text = arrows.ToString();
            tbWarnings.Clear();
            tbMessages.Clear();
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
            _gameControl.setArrowMode(true);
            displayArrowShotDirections(true);
            
        }

        private void btnCancelArrow_Click(object sender, EventArgs e)
        {
            _gameControl.setArrowMode(false);
            displayArrowShotDirections(false);
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

        private void displayArrowShotDirections(bool show)
        {
            if (show)
            {
                pbArrowNorth.BringToFront();
                pbArrowNortheast.BringToFront();
                pbArrowSoutheast.BringToFront();
                pbArrowSouth.BringToFront();
                pbArrowSoutheast.BringToFront();
                pbArrowSouthwest.BringToFront();
            }
            else
            {
                pbArrowNorth.SendToBack();
                pbArrowNortheast.SendToBack();
                pbArrowSoutheast.SendToBack();
                pbArrowSouth.SendToBack();
                pbArrowSoutheast.SendToBack();
                pbArrowSouthwest.SendToBack();
            }
        }

        private void pbArrowNorth_Click(object sender, EventArgs e)
        {
            _gameControl.arrowShotDirection("north");
            displayArrowShotDirections(false);
        }

        private void pbArrowNortheast_Click(object sender, EventArgs e)
        {
            _gameControl.arrowShotDirection("northeast");
            displayArrowShotDirections(false);
        }

        private void pbArrowSoutheast_Click(object sender, EventArgs e)
        {
            _gameControl.arrowShotDirection("southeast");
            displayArrowShotDirections(false);
        }

        private void pbArrowSouth_Click(object sender, EventArgs e)
        {
            _gameControl.arrowShotDirection("south");
            displayArrowShotDirections(false);
        }

        private void pbArrowSouthwest_Click(object sender, EventArgs e)
        {
            _gameControl.arrowShotDirection("southwest");
            displayArrowShotDirections(false);
        }

        private void pbArrowNorthwest_Click(object sender, EventArgs e)
        {
            _gameControl.arrowShotDirection("northwest");
            displayArrowShotDirections(false);
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

        public void displayHazardWarning(string hazard)
        {
            if (hazard.Equals("pit"))
            {
                tbWarnings.Text = "I feel a draft";
            }
            if (hazard.Equals("bats"))
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
            if (hazard.Equals("wumpus"))
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

    }

}
