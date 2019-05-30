using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Room
    {

        private int[] surrounding;
        private int[] available;
        private int PossConn;
        private int RoomNum;

        public Room()
        {
            surrounding = new int[6] { 1, 2, 3, 4, 5, 6 };
            available = new int[3]{ 1, 2, 3 };
            PossConn = 2;
            RoomNum = 1;
        }

        public Room(int RoomNum, int ConnNum)
        {
            this.RoomNum = RoomNum;
            PossConn = ConnNum;
        }
        
        public int[] getSurrounding()
        {   
            return surrounding;
        }

        public int[] getAvailable()
        {
            return available;
        }

        public void setAvailable(int a, int b, int c)
        {
            if(PossConn == 2)
            {
                
                available = new int[2]{ a, b };
            }
            else if(PossConn == 3)
            {
               available = new int[3]{ a, b, c };
            }
            else
            {
                available = new int[1] { a };
            }
        }

        public void setSurrounding(int a, int b, int c, int d)
        {
            surrounding = new int[6] { 0, a, b, c, d, 0 };
        }

        public void finishSurrounding (int a, int b)
        {
            surrounding[0] = a;
            surrounding[5] = b;
        }

        public void setSurrounding(int a, int b, int c, int d, int e, int f)
        {
            surrounding = new int[6] { a, b, c, d, e, f };
        }

        public int getRoomNum()
        {
            return RoomNum;
        }

        public int getPossConn()
        {
            return PossConn;
        }

        public void setPossConn(int u)
        {
            PossConn = u;
        }

    }

}
