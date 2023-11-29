using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management_System
{
    public class Guest : Person
    {
        private float invoice;
        private string roomID;
        private System.DateTime check_in_date;
        private System.DateTime check_out_date;

        public float Invoice { get => invoice; set => invoice = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public DateTime Check_in_date { get => check_in_date; set => check_in_date = value; }
        public DateTime Check_out_date { get => check_out_date; set => check_out_date = value; }

        public Guest(string id, string name, string gender, DateTime birth, int phoneNumber, string address, 
            float invoice, string roomID, System.DateTime check_in_date, System.DateTime check_out_date): base(id, name, gender, birth, phoneNumber, address)
        {
            Invoice = invoice;
            RoomID = roomID;
            Check_in_date = check_in_date;
            Check_out_date = check_out_date;
        }

        public override void PrintDetails()
        {
            throw new System.NotImplementedException();
        }

        public void MakeReservation()
        {
            throw new System.NotImplementedException();
        }

        public void RequestService()
        {
            throw new System.NotImplementedException();
        }
    }
}