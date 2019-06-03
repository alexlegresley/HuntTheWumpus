using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{ 
    public class Player
    {

        // instance variables
        private int arrows;
        private int coins;
        private int roomNumber;
        // constructor
        public Player()
        {
            coins = 100;
            arrows = 0;
            Random RNG = new Random();
            roomNumber = getValidRoomNumber(RNG);
        }
        // postcondition: a random number between 1-30 inclusive is returned
        private int getValidRoomNumber(Random RNG)
        {
            return RNG.Next(29) + 1;
        }
        // this allows gold amount to be changed
        public void setCoins(int k)
        {
            coins = k;
        }
        public void addOneCoin()
        {
            coins++;
        }
        // often gold is being reduced by one so this method is for convenience
        public void spendOneCoin()
        {
            coins--;
        }
        // often arrows are being increased by two so this method is for convenience
        public void addTwoArrows()
        {
            arrows += 2;
        }
        // often arrows are being decreased by one so this method is for convenience
        public void SpendAnArrow()
        {
            arrows--;
        }
        // simple accessors
        public int getArrows()
        {
            return arrows;
        }

        public int getCoins()
        {
            return coins;
        }

        public int getRoomNumber()
        {
            return roomNumber;
        }
        // precondition: k is between 1-30 inclusive
        // postcondition: if k is a valid int between 1-30 that will become the player's new room number
        public void setRoomNumber(int k)
        {
            if (k <= 30)
            {
                roomNumber = k;
            }
        }

    }

}

