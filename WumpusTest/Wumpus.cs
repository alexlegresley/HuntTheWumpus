using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Wumpus
    {

        // instance variables
        private Random random = new Random();
        private int roomNumber;

        public Wumpus(int playerRoom, int batARoom, int batBRoom, int pitARoom, int pitBRoom)
        {
            getStartingRoom(playerRoom, batARoom, batBRoom, pitARoom, pitBRoom);
        }

        private void getStartingRoom(int playerRoom, int batARoom, int batBRoom, int pitARoom, int pitBRoom)
        {
            do
            {
                roomNumber = random.Next(29) + 1;
            } while (roomNumber == playerRoom || roomNumber == batARoom || roomNumber == batBRoom ||
               roomNumber == pitARoom || roomNumber == pitBRoom);
        }

        public int updateRoom(int playerRoom, int batARoom, int batBRoom, int pitARoom, int pitBRoom)
        {
            do
            {
                roomNumber = random.Next(29) + 1;
            } while (roomNumber == playerRoom || roomNumber == batARoom || roomNumber == batBRoom ||
               roomNumber == pitARoom || roomNumber == pitBRoom);
            return roomNumber;
        }

        public int getWumpusRoom()
        {
            return roomNumber;
        }
        public boolean wumpusAdjacent(Room myRoom){
            for(int k=0;k<6;k++){
                if(roomNumber==myRoom.getSurrounding()[k]){
                    return true;
                }
            }
        }
    }

}
