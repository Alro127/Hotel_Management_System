using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management_System
{
    public abstract class Person
    {
        private string id;
        private string name;
        private string gender;
        private DateTime birth;
        private int phoneNumber;
        private string address;

        public Person(string id, string name, string gender, DateTime birth, int phoneNumber, string address)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Birth = birth;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }

        public abstract void PrintDetails();
    }
}