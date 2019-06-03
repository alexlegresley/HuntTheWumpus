
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Wumpus
{
    class Cave
    {
        Random r = new Random(); // initialize variables
        ArrayList unusedRoom = new ArrayList();
        public Room[] cave; // cave instance variable/field
        public Cave()
        {
            int caveSize = 30; // size of cave
            cave = new Room[caveSize]; // intialize to specified size
            ArrayList roomNumbers = new ArrayList(); // the overall idea of the randomly generated cave is to randomize the numbers but maintain the index interactions
                                                  // this array was created to randomize the room numbers

            for (int k = 1; k <= 30; k++)
            {
                numbers.Add(k); // populates the array
            }
            int n = 29;
            while (n > 1) // randomizes the array
            {
                n--;
                int k = r.Next(n + 1);
                int value = (int) roomNumbers[k];
                roomNumbers[k] = roomNumbers[n];
                roomNumbers[n] = value;
            }
            for (int k = 0; k < 30; k++)
            {
                cave[k] = new Room((int)numbers[k], r.Next(2) + 2); // populates cave with rooms with two to three possible connections
            }
            Sort(); // sorts the rooms based on number of possible connections
            cave[0].setAvailable(cave[1].getRoomNum(), cave[2].getRoomNum(), 119); // sets available rooms for first cave
            int i; // i initialized here to be accessible to second for loop
            for (i = 1; i < 1000; i++) // runs until a room with three possible connections occurs ;)
            {

                cave[i].setAvailable(cave[i - 1].getRoomNum(), cave[i + 1].getRoomNum(), 117);
                if (cave[i + 1].getPossConn() == 3) // detects if a room has three possible connections
                {
                    cave[i + 1].setAvailable(cave[i].getRoomNum(), cave[i + 2].getRoomNum(), cave[i + 3].getRoomNum());
                    cave[i + 2].setAvailable(cave[i + 1].getRoomNum(), cave[i + 3].getRoomNum(), cave[i + 4].getRoomNum());
                    break; // escape for loop
                }
            }
            for (int k = (i + 3); k < 29; k++) // starts operating 3 rooms after the last room with two possible connections
            {
                cave[k].setAvailable(cave[k - 2].getRoomNum(), cave[k - 1].getRoomNum(), cave[k + 1].getRoomNum());
            }
            cave[29].setPossConn(1); // changes number of possible connections for last room
            cave[29].setAvailable(cave[28].getRoomNum(), 58, 65);
            setAdjacentRooms();
        } 

        // precondition: cave is already initialized
        // postcondition: each room in cave system will have adjacent rooms set
        // overall idea is the interactions between the rooms based on index is the same yet the room numbers of each index is randomized in the intial constructor
        // so the rooms adjacent rooms are also random

       
        public void setAdjacentRooms()
        {
            cave[0].setSurrounding(cave[1].getRoomNum(), cave[2].getRoomNum(), cave[29].getRoomNum(), cave[23].getRoomNum(), cave[22].getRoomNum(), cave[21].getRoomNum());
            cave[1].setSurrounding(cave[0].getRoomNum(), cave[2].getRoomNum(), cave[3].getRoomNum(), cave[27].getRoomNum(), cave[28].getRoomNum(), cave[29].getRoomNum());
            cave[29].setSurrounding(cave[1].getRoomNum(), cave[2].getRoomNum(), cave[0].getRoomNum(), cave[3].getRoomNum(), cave[27].getRoomNum(), cave[28].getRoomNum());
            cave[28].setSurrounding(cave[29].getRoomNum(), cave[27].getRoomNum(), cave[26].getRoomNum(), cave[1].getRoomNum(), cave[22].getRoomNum(), cave[3].getRoomNum());
            for (int k = 2; k < 28; k++)
            {
                cave[k].setSurrounding(cave[k + 1].getRoomNum(), cave[k - 2].getRoomNum(), cave[k + 2].getRoomNum(), cave[k - 1].getRoomNum());
            }
           cave[2].finishSurrounding(cave[29].getRoomNum(), cave[21].getRoomNum());
            cave[3].finishSurrounding(cave[29].getRoomNum(), cave[28].getRoomNum());
            cave[4].finishSurrounding(cave[27].getRoomNum(), cave[25].getRoomNum());
            cave[5].finishSurrounding(cave[25].getRoomNum(), cave[24].getRoomNum());
            cave[6].finishSurrounding(cave[23].getRoomNum(), cave[24].getRoomNum());
            cave[7].finishSurrounding(cave[10].getRoomNum(), cave[11].getRoomNum());
            cave[8].finishSurrounding(cave[11].getRoomNum(), cave[12].getRoomNum());
            cave[9].finishSurrounding(cave[12].getRoomNum(), cave[13].getRoomNum());
            cave[10].finishSurrounding(cave[7].getRoomNum(), cave[13].getRoomNum());
            cave[11].finishSurrounding(cave[7].getRoomNum(), cave[8].getRoomNum());
            cave[12].finishSurrounding(cave[8].getRoomNum(), cave[9].getRoomNum());
            cave[13].finishSurrounding(cave[9].getRoomNum(), cave[10].getRoomNum());
            cave[14].finishSurrounding(cave[18].getRoomNum(), cave[17].getRoomNum());
            cave[15].finishSurrounding(cave[19].getRoomNum(), cave[20].getRoomNum());
            cave[16].finishSurrounding(cave[19].getRoomNum(), cave[20].getRoomNum());
            cave[17].finishSurrounding(cave[26].getRoomNum(), cave[14].getRoomNum());
            cave[18].finishSurrounding(cave[26].getRoomNum(), cave[14].getRoomNum());
            cave[19].finishSurrounding(cave[15].getRoomNum(), cave[16].getRoomNum());
            cave[20].finishSurrounding(cave[15].getRoomNum(), cave[16].getRoomNum());
            cave[21].finishSurrounding(cave[0].getRoomNum(), cave[2].getRoomNum());
            cave[22].finishSurrounding(cave[0].getRoomNum(), cave[28].getRoomNum());
            cave[23].finishSurrounding(cave[6].getRoomNum(), cave[0].getRoomNum());
            cave[24].finishSurrounding(cave[5].getRoomNum(), cave[6].getRoomNum());
            cave[25].finishSurrounding(cave[4].getRoomNum(), cave[5].getRoomNum());
            cave[26].finishSurrounding(cave[17].getRoomNum(), cave[18].getRoomNum());
            cave[27].finishSurrounding(cave[1].getRoomNum(), cave[4].getRoomNum()); 
        }

        // precondition: parameters are two integers between 1 and 30
        // postcondition: returns boolean that is true if the moveTo is included in the available array of room
        public Boolean isValidMove(int room, int moveTo)
        {
            int[] temp= cave[getIndex(room)].getAvailable(); // stores index of the room so it can be accessed further
            for(int k = 0; k < temp.Length; k++)
            {
                if (temp[k] == moveTo)
                {
                    return true;
                }
            }
            return false;
        }
        // precondition: parameter is an integer between 1 and 30
        // postcondition: the index of the room with roomNumber roomNum
        // since index is not the same as room number to maintain randomness a method is necesssary to find the index if given a room number
        public int getIndex(int roomNum)
        {
            for (int k = 0; k < 30; k++)
            {
                
                    if (cave[k].getRoomNum() == roomNum)
                    {
                        return k;
                    }
                }
                return -1;
            }
        // precondition: cave is propogated with rooms
        // postcondition: the cave is sorted by possible connections
        
        public void Sort()
        {
            Boolean swap = true;
            while (swap) // bubblesort was used as only 30 objects are being compared so the loss of efficiency is neglible
            {
                swap = false;
                for (int k = 0; k < 29; k++)
                {
                    if (cave[k].getPossConn() > cave[k + 1].getPossConn())
                    {
                        swap = true;
                        Room temp = cave[k];
                        cave[k] = cave[k + 1];
                        cave[k + 1] = temp;
                    }
                }
            }
        }
        // precondition: index is an integer between 0 and 29
        // postcondition: the room at a specific index is returned
        public Room getRoomByIndex(int index)
        {
            return cave[index];
        }
     public Room getRoombyRoomNumber(int roomNumber)
        {
            int index = getIndex(roomNumber);
            return cave[index];
        }
            
        }
    }


