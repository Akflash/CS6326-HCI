/*
 * Assignment 2
 *RebateRecord - Model for each record 
 * Written by Akshay Kumar for CS6326.001 on Sep 19, 2020.
 * NetID: axk180196
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Asg2_axk180196
{ 
    class RebateRecord
    {
        
         //  User entered and saved information saved in rebaterecord using getters and setters. (Includes hidden fields as well)
         
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Proof { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime SaveTime { get; set; }
        public int Backspace { get; set; }

       
        //  Default Constructor 
       
        public RebateRecord()
        {
            firstName = "";
            middleInitial = "";
            lastName = "";
            Address1 = "";
            Address2 = "";
            City = "";
            State = "";
            Zip = "";
            Gender = "";
            Phone = "";
            Email = "";
            Proof = "";
            Date = DateTime.MinValue;
            StartTime = DateTime.MinValue;
            SaveTime = DateTime.MinValue;
            Backspace = 0;
        }

       
          // User entered values added to respective field variables inside the constructor
          
        public RebateRecord(String firstname, String midinitial, String lastname,
            String address1, String address2, String city, String state,
            String zip, String gender, String phone, String email, String proof,
            DateTime date, DateTime startTime, DateTime saveTime, int backspace)
        {
            firstName = firstname;
            middleInitial = midinitial;
            this.lastName = lastname;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
            Gender = gender;
            Phone = phone;
            Email = email;
            Proof = proof;
            Date = date;
            StartTime = startTime;
            SaveTime = saveTime;
            Backspace = backspace;
        }

      
         //   Copy Constructor sets values from another object while update or modify 
          
        public RebateRecord(RebateRecord obj)
        {
            firstName = obj.firstName;
            middleInitial = obj.middleInitial;
            lastName = obj.lastName;
            Address1 = obj.Address1;
            Address2 = obj.Address2;
            City = obj.City;
            State = obj.State;
            Zip = obj.Zip;
            Gender = obj.Gender;
            Phone = obj.Phone;
            Email = obj.Email;
            Proof = obj.Proof;
            Date = obj.Date;
            StartTime = obj.StartTime;
            SaveTime = obj.SaveTime;
            Backspace = obj.Backspace;
        }

       
         //   Returns String which satisfies the given format of the file.

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}" +
                "\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}",
                firstName, middleInitial, lastName, Address1, Address2, City, State,     
                Zip, Gender,  
                Phone, Email, Proof, 
                Date.Date.ToString("d"), StartTime.ToString("HH:mm:ss"), 
                SaveTime.ToString("HH:mm:ss"), Backspace) ;
        }

        
        //   Returns true if the RebateRecord has the same first name, last name and phone number
       
        public override bool Equals(Object obj)
        {
            RebateRecord rebateObject = obj as RebateRecord;
            if (rebateObject == null)
                return false;
            else
                return firstName.Equals(rebateObject.firstName) &&
                    lastName.Equals(rebateObject.lastName) &&
                    Phone.Equals(rebateObject.Phone);
        }

       
          //  Override check
         
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
