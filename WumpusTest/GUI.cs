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
        GameControl gc;

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
            gc = new GameControl();
        }

        // get user name
        private void btnDone_Click(object sender, EventArgs e)
        {
            /*if(tbName.Text.Length > 0)
            {
                _gc.setName(tbName.Text);
            }
            else
            {
                _gc.setName("Anonymous");
            } */
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

    }
}
