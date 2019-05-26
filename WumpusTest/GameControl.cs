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
        private GUI gui;
        private Cave c;
        private PlayerControl pc;
        private GameLocations gl;
        private Hazards h;
        private Trivia t;
        private HighScore hs;
        private int turns;
        private String name;

        public GameControl()
        {
        }

        public void beginGame()
        {
            gui   = new GUI();
            c     = new Cave();
            pc    = new PlayerControl();
            gl    = new GameLocations();
            h     = new Hazards();
            t     = new Trivia();
            hs    = new HighScore();
            turns = 0;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        private void endGame()
        {
            int score = calculateScore();
            hs.addScore(name, score);
            gui.displayMainMenu();
        }

        private int calculateScore()
        {
            int score = 100 - turns + pc.getCoins() + (5 * pc.getArrows());
            if (!h.wumpusAlive())
            {
                score += 50;
            }
            return score;
        }

        public void movePlayer(int index)
        {
            if (roomValid(index))
            {
                if (pc.getCoins - 1 >= 0)
                {
                    gl.setCurrentRoom(c.getAdjacentRooms[gl.getCurrentRoom][index]);
                    pc.addCoin();
                    gui.displayRoom(gl.getCurrentRoom, c.getAdjacentRooms(gl.getCurrentRoom));
                    turns++;
                }
                else
                {
                    endGame();
                }
            }
        }

        private Boolean roomValid(int index)
        {
            return c.getAdjacentRooms[gl.getCurrentRoom][index] != -1;
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
            // sends an array of adjacent rooms to game locations and receives whether a hazard is adjacent, and what type
            // calls user interface to display a message for the adjacent hazard
        }

        public void shootArrow()
        {
            // call game location with selected room to determine if the Wumpus was in the room to which the arrow was shot
            // if Wumpus is not killed and that was the last arrow, end the game
        }

    }

}
