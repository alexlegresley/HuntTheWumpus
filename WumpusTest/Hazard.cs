using System;
namespace Wumpus

{ 
public class Hazard 
{
    private int currentRoom;
    private int destinationRoom;
    public Hazard(int c, int d)
        {
            currentRoom = c;
            destinationRoom = d;
        }
    public int getCurrentRoom()
        {
            return currentRoom();
        }
    public int getDestination()
        {
            return destinationRoom;
        }
    public String HazardType()
        {
            if (currentRoom == destinationRoom)
            {
                return "Pit";
            }
            return "Bat";
        }
    }
}