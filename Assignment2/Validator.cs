/*
 * Assignment 2
 * Validator -Validates all fields
 * Written by Akshay Kumar for CS6326.001 on Sep 19, 2020.
 * NetID: axk180196
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asg2_axk180196
{
    public static class Validator
    {
        
          // Empty Field check
          
        public static bool ValidateTextField(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;
            return true;
        }

       
        //   Checks if SelectedValue in ComboBox is not null or not.
        
        public static bool ValidateComboBox(object obj)
        {
            if (obj == null)
                return false;
            return true;
        }

       
         // Returns Boolean true value if entered text is a group of letters
           
        public static bool ValidateInitial(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return true;
            if (Regex.IsMatch(str, @"[a-zA-Z]"))
                return true;
            return false;
        }

       
        //   Checks whether if the entered ZipCode Length is between 5 to 9
         
        public static bool ValidateZipCode(string zipCode)
        {
            if (!string.IsNullOrWhiteSpace(zipCode) && 
                (zipCode.Remove(5, 1).Trim().Length == 5 || zipCode.Remove(5, 1).Trim().Length == 9))
                return true;
            return false;
        }

        //  Checks for right format of phoneNumber.
         
        public static bool ValidatePhoneNumber(string phn)
        {
            Regex rx = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (!string.IsNullOrWhiteSpace(phn) && rx.IsMatch(phn))
                return true;
            return false;
        }

        
        //   Checks for Valid Email
            
        public static bool ValidateEmailAddress(string email)
        {
            Regex rx = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]", RegexOptions.IgnoreCase);
            if (!string.IsNullOrWhiteSpace(email) && rx.IsMatch(email))
                return true;
            return false;
        }

        
        //   Checks if the  entered Date and Time is before the current day.
       
        public static bool ValidateDate(DateTime date)
        {
            if(date.Date.CompareTo(DateTime.Today.AddDays(1).AddTicks(-1)) <= 0)
                return true;
            return false;
        }
    }
}
