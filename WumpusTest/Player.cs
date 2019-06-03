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
        private int arrow;
        private int gold;
        private int roomNumber;
        // constructor
        public Player()
        {
            gold = 100;
            arrow = 0;
            Random RNG = new Random();
            roomNumber = getValidRoomNumber(RNG);
        }
        // postcondition: a random number between 1-30 inclusive is returned
        private int getValidRoomNumber(Random RNG)
        {
            return RNG.Next(29) + 1;
        }
        // this allows gold amount to be changed
        public void setGold(int k)
        {
            gold = k;
        }
        // often gold is being reduced by one so this method is for convenience
        public void spendOneGold()
        {
            gold--;
        }
        // often arrows are being increased by one so this method is for convenience
        public void addOneArrow()
        {
            arrow++;
        }
        // often arrows are being decreased by one so this method is for convenience
        public void SpendAnArrow()
        {
            arrow--;
        }
        // simple accessor
        public int getArrows()
        {
            return arrow;
        }
        // simple accessor
        public int getGold()
        {
            return gold;
        }
        // simple mutator
        public int getRoomNumber()
        {
            return roomNumber;
        }
        // a method gc can call to see if the game needs to be ended instantly
        public bool CanCanContinuePlaying()
        {
            if (arrow < 0 || gold < 0)
            {
                return false;
            }
            return true;
        }
        // simple mutator that checks if a valid roomNumber was passed
        public void setRoomNumber(int k)
        {
            if (k <= 30)
            {
                roomNumber = k;
            }
        }

    }

}



