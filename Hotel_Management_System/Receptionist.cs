using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management_System
{
    public class Receptionist : Person
    {
        private float salary;

        public float Salary { get => salary; set => salary = value; }

        public Receptionist(string id, string name, string gender, DateTime birth, int phoneNumber, string address, float salary) : base(id, name, gender, birth, phoneNumber, address)
        {
            Salary = salary;
        }

        public override void PrintDetails()
        {
            throw new System.NotImplementedException();
        }

        public void Check_In()
        {
            throw new System.NotImplementedException();
        }

        public void Check_Out()
        {
            throw new System.NotImplementedException();
        }
    }
}