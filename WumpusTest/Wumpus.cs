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
        private Cave _cave = new Cave();
        private Room _room;
        private int roomNumber;

        public Wumpus(int playerRoom)
        {
            getStartingRoom(playerRoom);
        }

        private void getStartingRoom(int playerRoom)
        {
            do
            {
                roomNumber = random.Next(29) + 1;
            } while (roomNumber == playerRoom);
        }

        public void runAwayAfterFight(int currentRoom)
        {
            int numTimesToRun = random.Next(2, 5);
            roomNumber = chooseRoomToRun(currentRoom, numTimesToRun);
        }

        // 25% chance that the wumpus runs to an adjacent room if the player shoots an arrow 
        public void runAwayAfterArrowShot(int currentRoom)
        {
            if (random.Next(0, 5) == 0)
            {
                roomNumber = chooseRoomToRun(currentRoom, 1);
            }
        }

        private int chooseRoomToRun(int currentRoom, int numTimesToRun)
        {
            int newRoom = currentRoom;
            for (int i = 0; i < numTimesToRun; i++)
            {
                _room = _cave.getRoombyRoomNumber(newRoom);
                int[] availableRooms = _room.getAvailable();
                newRoom = availableRooms[random.Next(0, availableRooms.Length)];
            }
            return newRoom;
        }

        public int getRoom()
        {
            return roomNumber;
        }

    }

}
