using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class HazardManager
    {

        // instance variables
        Random random = new Random();
        private int batARoom;
        private int batBRoom;
        private int pitARoom;
        private int pitBRoom;

        public HazardManager(int playerRoom)
        {
            setLocations(playerRoom);
        }

        private void setLocations(int playerRoom)
        {
            batARoom = batBRoom = pitARoom = pitBRoom = -1;
            batARoom = getNum(playerRoom);
            batBRoom = getNum(playerRoom);
            pitARoom = getNum(playerRoom);
            pitBRoom = pitARoom;
            pitBRoom = getNum(playerRoom);
        }

        private int getNum(int playerRoom)
        {
            int rand;
            do
            {
                rand = random.Next(29) + 1;
            } while (rand == playerRoom || rand == batARoom || rand == batBRoom ||
               rand == pitARoom || rand == pitBRoom);
            return rand;
        }

        public int getBatARoom()
        {
            return batARoom;
        }
        public bool isHazardAdjacent(Room testRoom){
            for(int k=0;k<6;k++){
                int test=testRoom.getSurrounding()[k];
                if(test==batARoom || test==batBRoom ||test==pitARoom ||test==pitBRoom){
                    return true;
                }
            }
        }
        public string HazardIdentity(int roomNum){
            if(roomNum==batARoom || roomNum==batBRoom){
                return "bat";
            }
            if(roomNum==pitARoom || roomNum==pitBRoom){
               return "pit";   
            }
            return "nothing";
        }
        public int getBatBRoom()
        {
            return batBRoom;
        }

        public int getPitARoom()
        {
            return pitARoom;
        }

        public int getPitBRoom()
        {
            return pitBRoom;
        }

    }

}
