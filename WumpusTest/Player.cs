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

        public Player()
        {
            coins = 10;
            arrows = 2;
            Random RNG = new Random();
            roomNumber = getValidRoomNumber(RNG);
        }

        private int getValidRoomNumber(Random RNG)
        {
            return RNG.Next(29) + 1;
        }

        public void setCoins(int k)
        {
            coins = k;
        }

        public void addOneCoin()
        {
            coins++;
        }

        public void spendOneCoin()
        {
            coins--;
        }

        public void addTwoArrows()
        {
            arrows += 2;
        }

        public void SpendAnArrow()
        {
            arrows--;
        }

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

        public void setRoomNumber(int k)
        {
            if (k <= 30)
            {
                roomNumber = k;
            }
        }

    }

}



