using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WumpusTest
{
    class Cave
    {

        Random r = new Random();
        ArrayList unusedRoom = new ArrayList();
        public Room[] cave;

        public Cave()
        {
            cave = new Room[30];
            ArrayList numbers = new ArrayList();

            for (int k = 1; k <= 30; k++)
            {
                numbers.Add(k);
            }
            int n = 29;
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                int value = (int) numbers[k];
                numbers[k] =numbers[n];
                numbers[n] = value;
            }
            for (int k = 0; k < 30; k++)
            {
                cave[k] = new Room((int)numbers[k], r.Next(2) + 2);
            }
            Sort();
            cave[0].setAvailable(cave[1].getRoomNum(), cave[2].getRoomNum(), 119);
            int i;
            for (i = 1; i < 1000; i++)
            {
                cave[i].setAvailable(cave[i - 1].getRoomNum(), cave[i + 1].getRoomNum(), 117);
                if (cave[i + 1].getPossConn() == 3)
                {
                    cave[i + 1].setAvailable(cave[i].getRoomNum(), cave[i + 2].getRoomNum(), cave[i + 3].getRoomNum());
                    cave[i + 2].setAvailable(cave[i + 1].getRoomNum(), cave[i + 3].getRoomNum(), cave[i + 4].getRoomNum());
                    break;
                }
            }
            for (int k = (i + 3); k < 29; k++)
            {
                cave[k].setAvailable(cave[k - 2].getRoomNum(), cave[k - 1].getRoomNum(), cave[k + 1].getRoomNum());
            }
            cave[29].setPossConn(1);
            cave[29].setAvailable(cave[28].getRoomNum(), 58, 65);
            setAdjacentRooms();
        }

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

        public Boolean isValidMove(int room, int moveTo)
        {
            int[] temp= cave[getIndex(room)].getAvailable();
            for(int k = 0; k < temp.Length; k++)
            {
                if (temp[k] == moveTo)
                {
                    return true;
                }
            }
            return false;
        }

        public void reset()
        {
            for (int i = 1; i <= 30; i++)
            {
                unusedRoom.Add(i);
            }
        }

        public int GetNum()
        {
            int k = unusedRoom.Count;
            int index = r.Next(k);
            int a = (int)unusedRoom[index];
            unusedRoom.Remove(index);
            return (a - 1);
        }
    
        public ArrayList newArray()
        {
            ArrayList possRoom = new ArrayList();
            for (int i = 1; i <= 30; i++)
            {
                possRoom.Add(i);
            }
            return possRoom;
        }

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

        public void Sort()
        {
            Boolean swap = true;
            while (swap)
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


