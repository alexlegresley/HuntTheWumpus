
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class HazardManager
    {

        // purpose of this object is to handle all interactions with hazards 
        // so that game control does not have to interact with
        // each individual hazard but rather this hazard manager
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

       

        public int carryPlayerToNewRoom(int currentPlayerRoom)
        {
            // get a new room for the bat to carry the player to
            int newPlayerRoom = getNum(currentPlayerRoom);
            /* determine the bat that carried the player to the new room and reset its
               location in another random room */
            if (batARoom == currentPlayerRoom)
            {
                batARoom = getNum(newPlayerRoom);
            }
            else
            {
                batBRoom = getNum(newPlayerRoom);
            }
            // return the new player room
            return newPlayerRoom;
        }
        // simple accessors
        public int getBatARoom()
        {
            return batARoom;
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

        // place the pit that the player encountered in a new random room
        public void resetPitRoom(int currentPlayerRoom)
        {
            if (pitARoom == currentPlayerRoom)
            {
                pitARoom = getNum(currentPlayerRoom);
            }
            else
            {
                pitBRoom = getNum(currentPlayerRoom);
            }
        }

    }
