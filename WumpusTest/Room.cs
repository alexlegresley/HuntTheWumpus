using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Room
    {
        // instance variables
        private int[] surrounding; // an array of rooms adjacent to current room
        private int[] available; // an array of rooms player could move to from the current room
        private int PossConn; // how many rooms the rooms can go to (will be between 1-3)
        private int RoomNum; // the room number
        // default constructor shouldn't be used
        public Room()
        {
            surrounding = new int[6] { 1, 2, 3, 4, 5, 6 }; 
            available = new int[3]{ 1, 2, 3 };
            PossConn = 2;
            RoomNum = 1;
        }
        // sets the roomNumber and the number of rooms the room can go to
        public Room(int RoomNum, int ConnNum)
        {
            this.RoomNum = RoomNum;
            PossConn = ConnNum;
        }
        // simple accessor
        public int[] getSurrounding()
        {   
            return surrounding;
        }
        // simple accessor
        public int[] getAvailable()
        {
            return available;
        }
        // precondition: a,b,c are all integers between 1-30 inclusive
        // postcondition: the room has the available rooms set
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
        // this sets the adjacent rooms 
        public void setSurrounding(int a, int b, int c, int d)
        {
            surrounding = new int[6] { 0, a, b, c, d, 0 };
        }
        // this method is to finish surrounding rooms if the above method was used
        // the purpose of this system of methods is to allow the cave have all the tools it needs to make the cave
        public void finishSurrounding (int a, int b)
        {
            surrounding[0] = a;
            surrounding[5] = b;
        }
        // overloaded method to set all the adjacent rooms
        // precondition: a,b,c,d,e,f all integers between 1-30 inclusive
        public void setSurrounding(int a, int b, int c, int d, int e, int f)
        {
            surrounding = new int[6] { a, b, c, d, e, f };
        }
        // simple accessor
        public int getRoomNum()
        {
            return RoomNum;
        }
        // this accessor is specifically so cave can sort the rooms by how many rooms they can access
        public int getPossConn()
        {
            return PossConn;
        }
        // this mutator exists solely so the last room can be set to have only 1 possible room to go to.
        public void setPossConn(int u)
        {
            PossConn = u;
        }

    }

}
