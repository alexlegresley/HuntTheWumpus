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
        GameControl _gameControl;

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
        }
        private void btnStToMM_Click(object sender, EventArgs e)
        {
            pnMainMenu.BringToFront();
        }


        // show high scores
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            /*HighScore hs = new HighScore();
            hs.displayScores();*/
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

        public void setRoomStates(int[] surroundingRooms, int[] availableRooms)
        {
            foreach (int room in availableRooms)
            {
                if (surroundingRooms[0] == room)
                {
                    pbNorth.Image = Properties.Resources.North_Door;
                    pbNorth.Enabled = true;
                }
                else
                {
                    pbNorth.Image = Properties.Resources.North_NoDoor;
                    pbNorth.Enabled = false;
                }
                if (surroundingRooms[1] == room)
                {
                    pbNortheast.Image = Properties.Resources.Northeast_Door;
                    pbNortheast.Enabled = true;
                }
                else
                {
                    pbNortheast.Image = Properties.Resources.Northeast_NoDoor;
                    pbNortheast.Enabled = false;
                }
                if (surroundingRooms[2] == room)
                {
                    pbSoutheast.Image = Properties.Resources.Southeast_Door;
                    pbSoutheast.Enabled = true;
                }
                else
                {
                    pbSoutheast.Image = Properties.Resources.Southeast_NoDoor;
                    pbSoutheast.Enabled = false;
                }
                if (surroundingRooms[3] == room)
                {
                    pbSouth.Image = Properties.Resources.South_Door;
                    pbSouth.Enabled = true;
                }
                else
                {
                    pbSouth.Image = Properties.Resources.South_NoDoor;
                    pbSouth.Enabled = false;
                }
                if (surroundingRooms[4] == room)
                {
                    pbSouthwest.Image = Properties.Resources.Southwest_Door;
                    pbSouthwest.Enabled = true;
                }
                else
                {
                    pbSouthwest.Image = Properties.Resources.Southwest_NoDoor;
                    pbSouthwest.Enabled = false;
                }
                if (surroundingRooms[5] == room)
                {
                    pbNorthwest.Image = Properties.Resources.Northwest_Door;
                    pbNorthwest.Enabled = true;
                }
                else
                {
                    pbNorthwest.Image = Properties.Resources.Northwest_NoDoor;
                    pbNorthwest.Enabled = false;
                }
            }
        }

        private void pbNorth_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer();
        }

        private void pbNortheast_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer();
        }

        private void pbSoutheast_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer();
        }

        private void pbSouth_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer();
        }

        private void pbSouthwest_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer();
        }

        private void pbNorthwest_Click(object sender, EventArgs e)
        {
            _gameControl.movePlayer();
        }
    }
}
