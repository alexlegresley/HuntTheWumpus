﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{ 
    public class Hazard 
    {

        private int currentRoom;
        private int destinationRoom;

        public Hazard(int room)
        {
            currentRoom = room;
        }

        public int getCurrentRoom()
        {
            return currentRoom;
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