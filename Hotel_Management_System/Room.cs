using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management_System
{
    public class Room
    {
        private string id;
        private string type;
        private float cost;

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public float Cost { get => cost; set => cost = value; }

        public Room(string id, string type, float cost)
        {
            Id = id;
            Type = type;
            Cost = cost;
        }
    }
}