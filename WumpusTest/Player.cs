using System;

namespace Wumpus


{ 
    public class Player
{

    private int arrow;
    private int gold;
        private int roomNumber;
        private Hazard BatA;
    private Hazard BatB;
   private Hazard PitA;
    private Hazard PitB;
        public Player()

        {

            gold = 0;
            arrow = 0;
            Random RNG = new Random();
            roomNumber = getValidRoomNumber(RNG);
            int c;
            int d;
            int a;
            int b;
            int e;
            int f;
            do
            {
                c = getValidRoomNumber(RNG);
            } while (c == roomNumber);
            do
            {
                d = getValidRoomNumber(RNG);
            }
            while (d != c);
            BatA = new Hazard(c, d);
            do
            {
                b = getValidRoomNumber(RNG);
            } while (b == c || b == roomNumber);
            do
            {
                a = getValidRoomNumber(RNG);
            }
            while (a == c || a == b);
            BatB = new Hazard(b, a);
            do
            {
                e = getValidRoomNumber(RNG);
            }
            while (e == c || e==b);
            PitA = new Hazard(e, e);
            do
            {
                f = getValidRoomNumber(RNG);
            }
            while (f == c || f == b || f==e);
            PitB = new Hazard(f, f);

        }
    public int getValidRoomNumber(Random RNG)
        {
            return RNG.Next(29) + 1;
        }
    public void setGold(int k)
    {
        gold = k;
    }
    public void addOneGold()
    {
        gold++;
    }
    public void addOneArrow()
    {
        arrow++;
    }
    public void SpendAnArrow()
    {
        arrow--;
    }
    public int getArrow()
    {
        return arrow;
    }
    public int getGold()
    {
        return gold;
    }
    public int getRoomNumber()
    {
        return roomNumber;
    }
    public bool CanCanContinuePlaying()
    {
        if (arrow < 0 || gold < 0)
        {
            return false;
        }
        return true;
    }
    public void setRoomNumber(int k)
    {
        if (k <= 30)
        {
            roomNumber = k;
        }
    }
    public Boolean checkHazard()
        {
            return roomNumber == BatA.getCurrentRoom() || roomNumber == BatB.getCurrentRoom() || roomNumber == PitB.getCurrentRoom() || roomNumber == PitA.getCurrentRoom();
        }  
    public void HazardAction()
        {
            if (BatA.getCurrentRoom() == roomNumber)
            {
                roomNumber = BatA.getDestination();
            }
            else if (BatB.getCurrentRoom() == roomNumber)
            {
                roomNumber = BatB.getDestination();
            } else if (PitA.getCurrentRoom() == roomNumber)
            {
                // implement pit action after discussing with team
            }
            else
            {
                // implement pit action
            }
        }
}
}



