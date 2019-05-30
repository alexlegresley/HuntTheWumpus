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

        public Player()
        {
            gold = 0;
            arrow = 0;
            Random RNG = new Random();
            roomNumber = getValidRoomNumber(RNG);
        }

        private int getValidRoomNumber(Random RNG)
        {
            return RNG.Next(29) + 1;
        }

        public void setGold(int k)
        {
            gold = k;
        }

        public void addOneGold()
        {
            gold++;
        }

        public void addOneArrow()
        {
            arrow++;
        }

        public void SpendAnArrow()
        {
            arrow--;
        }

        public int getArrow()
        {
            return arrow;
        }

        public int getGold()
        {
            return gold;
        }

        public int getRoomNumber()
        {
            return roomNumber;
        }

        public bool CanCanContinuePlaying()
        {
            if (arrow < 0 || gold < 0)
            {
                return false;
            }
            return true;
        }

        public void setRoomNumber(int k)
        {
            if (k <= 30)
            {
                roomNumber = k;
            }
        }

    }

}



