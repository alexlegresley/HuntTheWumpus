using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class HazardManager
    {
        // purpose of this object is to handle all interactions with hazards so that game control does not have to interact with
        // each individual hazard but rather this hazard manager
        // instance variables
        Random random = new Random();
        // these variable represent each hazards location
        private int batARoom;
        private int batBRoom;
        private int pitARoom;
        private int pitBRoom;
        // this takes in the player's room so that the player doesn't start next to a hazard
        public HazardManager(int playerRoom)
        {
            setLocations(playerRoom);
        }
        
        private void setLocations(int playerRoom)
        {   // essentially this method calls a seperate method that gives a room that has nothing in it and sets each hazard to that
            batARoom = batBRoom = pitARoom = pitBRoom = -1;
            batARoom = getNum(playerRoom);
            batBRoom = getNum(playerRoom);
            pitARoom = getNum(playerRoom);
            pitBRoom = pitARoom; // otherwise pitBRoom would stay -1 as no other hazard or player is in roomNUM -1
            pitBRoom = getNum(playerRoom);
        }
        // precondition: the hazards and player has been assigned a roomNumber
        private int getNum(int playerRoom)
        {
            int rand;
            do // selects a random number and then checks if there is a hazard or player already in that room
            {
                rand = random.Next(29) + 1;
            } while (rand == playerRoom || rand == batARoom || rand == batBRoom ||
               rand == pitARoom || rand == pitBRoom);
            return rand;
        }
        // simple accessor
        public int getBatARoom()
        {
            return batARoom;
        } // allows game control to check if there is a hazard in an adjacent room to do the appropriate warnings
        public bool isHazardAdjacent(Room testRoom){
            for(int k=0;k<6;k++){
                int test=testRoom.getSurrounding()[k];
                if(test==batARoom || test==batBRoom ||test==pitARoom ||test==pitBRoom){
                    return true;
                }
            }
        } // returns the identity of the Hazard in a given room as a String
        public string HazardIdentity(int roomNum){
            if(roomNum==batARoom || roomNum==batBRoom){
                return "bat";
            }
            if(roomNum==pitARoom || roomNum==pitBRoom){
               return "pit";   
            }
            return "nothing";
        }
        // simple accessors
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
