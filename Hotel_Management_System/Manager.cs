using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management_System
{
    public class Manager : Person
    {
        private float salary;

        public float Salary { get => salary; set => salary = value; }

        public Manager(string id, string name, string gender, DateTime birth, int phoneNumber, string address, float salary): base(id, name, gender, birth, phoneNumber, address)
        {
            Salary = salary;
        }

        public override void PrintDetails()
        {
            throw new System.NotImplementedException();
        }

        public void ManageRoom()
        {
            throw new System.NotImplementedException();
        }

        public void ViewReports()
        {
            throw new System.NotImplementedException();
        }
    }
}