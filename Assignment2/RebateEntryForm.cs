/*
 * Assignment 2
 * RebateForm - Main
 * Written by Akshay Kumar for CS6326.001 on Sep 19, 2020.
 * NetID: axk180196
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Asg2_axk180196
{
    public partial class RebateEntryForm : Form
    {
        
        public const int ADD = 0;
        public const int MODIFY = 1;

        // hidden fields
        private DateTime start_time = DateTime.MinValue;
        private int backSpace_count = 0;
        private int curr_Mode;

        //  Delete Undo
        private RebateRecord deletedRecord;
        private int deletedRecordIndex;

        public RebateEntryForm()
        {
            InitializeComponent();
            expandScreen();
        }

   
        //   Expand the screen to fit size of working screen
      
        private void expandScreen()
        {
            
            this.CenterToScreen();
        }

         //  Load data file sets max date to this year and sets add mode.
        
        private void RebateForm_Load(object sender, EventArgs e)
        {
            RebateFileHandler rebate_File = new RebateFileHandler();
            rebate_File.ReadRebateList(RebateList);

            Date.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            UndoMenuItem.Enabled = false;
            SetAddMode();
        }

        private void FieldChanged(object sender, EventArgs e)
        {
            CanSave();
        }

        private void Date_Changed(object sender, EventArgs e)
        {
            
            SendKeys.Send("{RIGHT}");
            CanSave();
        }

        private void Date_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                SendKeys.Send("{RIGHT}");
                CanSave();
            }
        }
     
        
         // Enables save function if all fields are valid and required fields have been entered and no duplicates.
        
        private void CanSave()
        {
            // check if all required fields have been filled      
            bool valid_Entry = Validator.ValidateTextField(firstName.Text) &&
                        Validator.ValidateInitial(Minitial.Text) &&
                        Validator.ValidateTextField(lastName.Text) &&
                        Validator.ValidateTextField(Address1.Text) &&
                        Validator.ValidateTextField(City.Text) &&
                        Validator.ValidateComboBox(State.SelectedItem) &&
                        Validator.ValidateZipCode(Zip.Text) &&
                        Validator.ValidateComboBox(Gender.SelectedItem) &&
                        Validator.ValidatePhoneNumber(Phone.Text) &&
                        Validator.ValidateEmailAddress(Email.Text) &&
                        Validator.ValidateComboBox(Proof.SelectedItem) &&
                        Validator.ValidateDate(Date.Value);
            RebateRecord entered_Record = new RebateRecord();
         
            if(curr_Mode == MODIFY && RebateList.SelectedItems.Count != 0)
            {
                entered_Record = new RebateRecord((RebateRecord)RebateList.SelectedItems[0].Tag);
            }
            entered_Record.firstName = firstName.Text;
            entered_Record.middleInitial = Minitial.Text;
            entered_Record.lastName = lastName.Text;
            entered_Record.Address1 = Address1.Text;
            entered_Record.Address2 = Address2.Text;
            entered_Record.City = City.Text;
            entered_Record.State = State.Text;
            entered_Record.Zip = new string(Zip.Text.Where(char.IsDigit).ToArray()); //zipcode should only be numbers
            entered_Record.Gender = Gender.Text;
            entered_Record.Phone = new string(Phone.Text.Where(char.IsDigit).ToArray()); // phone number should only have numbers
            entered_Record.Email = Email.Text;
            entered_Record.Proof = Proof.Text;
            entered_Record.Date = Date.Value;
            switch (curr_Mode)
            {
                case ADD:
                    if (start_time.CompareTo(DateTime.MinValue) == 0)
                    {
                        start_time = DateTime.Now;
                    }   
                    
                    if (valid_Entry && !SearchListViewItem(RebateList, entered_Record)) //Duplicate records checked
                    {
                        Save.Enabled = true;
                        FieldError.SetError(firstName, "");
                        FieldError.SetError(lastName, "");
                        FieldError.SetError(Phone, "");
                    }
                    else
                    {
                        Save.Enabled = false;
                        if (SearchListViewItem(RebateList, entered_Record))
                        {
                            FieldError.SetError(firstName, "Found existing rebate with same name and phone number!");
                            FieldError.SetError(lastName, "Found existing rebate with same name and phone number!");
                            FieldError.SetError(Phone, "Found existing rebate with same name and phone number!");
                        }
                    }
                    break;

                case MODIFY:
                    if (valid_Entry && !SearchListViewItem(RebateList, entered_Record))
                    {
                        Save.Enabled = true;
                        FieldError.SetError(firstName, "");
                        FieldError.SetError(lastName, "");
                        FieldError.SetError(Phone, "");
                    }
                    else
                    {
                        Save.Enabled = false;
                        if (SearchListViewItem(RebateList, entered_Record))
                        {
                            FieldError.SetError(firstName, "Found existing rebate with same name and phone number!");
                            FieldError.SetError(lastName, "Found existing rebate with same name and phone number!");
                            FieldError.SetError(Phone, "Found existing rebate with same name and phone number!");
                        }
                    }
                    break;
            }
        }

        
           // After saving, the records are written to file.
         private void Save_Click(object sender, EventArgs e)
        {
            RebateRecord entered_Record;
            RebateFileHandler rebate_File = new RebateFileHandler();
            switch (curr_Mode)
            {
                case ADD:
                    entered_Record = new RebateRecord();
                    entered_Record.firstName = firstName.Text;
                    entered_Record.middleInitial = Minitial.Text;
                    entered_Record.lastName = lastName.Text;
                    entered_Record.Address1 = Address1.Text;
                    entered_Record.Address2 = Address2.Text;
                    entered_Record.City = City.Text;
                    entered_Record.State = State.Text;
                    entered_Record.Zip = new string(Zip.Text.Where(char.IsDigit).ToArray());
                    entered_Record.Gender = Gender.Text;
                    entered_Record.Phone = new string(Phone.Text.Where(char.IsDigit).ToArray());
                    entered_Record.Email = Email.Text;
                    entered_Record.Proof = Proof.Text;
                    entered_Record.Date = Date.Value;
                    entered_Record.StartTime = start_time;
                    entered_Record.SaveTime = DateTime.Now;
                    entered_Record.Backspace = backSpace_count;
                    if (!SearchListViewItem(RebateList, entered_Record))
                    {
                        AddListViewItem(RebateList, entered_Record);

                        rebate_File.WriteRebateList(RebateList);

                        ClearForm();

                    }
                    break;
                case MODIFY:
                    entered_Record = new RebateRecord((RebateRecord)RebateList.SelectedItems[0].Tag);
                    entered_Record.firstName = firstName.Text;
                    entered_Record.middleInitial = Minitial.Text;
                    entered_Record.lastName = lastName.Text;
                    entered_Record.Address1 = Address1.Text;
                    entered_Record.Address2 = Address2.Text;
                    entered_Record.City = City.Text;
                    entered_Record.State = State.Text;
                    entered_Record.Zip = new string(Zip.Text.Where(char.IsDigit).ToArray());
                    entered_Record.Gender = Gender.Text;
                    entered_Record.Phone = new string(Phone.Text.Where(char.IsDigit).ToArray());
                    entered_Record.Email = Email.Text;
                    entered_Record.Proof = Proof.Text;
                    entered_Record.Date = Date.Value;
                    if (!SearchListViewItem(RebateList, entered_Record))
                    {        
                        ModifyListViewItem(RebateList, entered_Record);
 
                        rebate_File.WriteRebateList(RebateList);

                        ClearForm();
                    }
                    break;
            }
        }
   
          //  Returns true if duplicate records are found in List.
   
        private bool SearchListViewItem(ListView list, RebateRecord entered_Record)
        {
            bool found = false;
            foreach (ListViewItem list_item in list.Items)
            {
                RebateRecord rebate_list_item = (RebateRecord) list_item.Tag;
                if (curr_Mode == ADD && entered_Record.Equals(rebate_list_item))
                    found = true;
                if (curr_Mode == MODIFY && entered_Record.Equals(rebate_list_item))
                    if(rebate_list_item != (RebateRecord)RebateList.SelectedItems[0].Tag)
                        found = true;
            }
            return found;
        }

        
           //  Adds a new record in List.
       
        private void AddListViewItem(ListView list, RebateRecord entered_Record)
        {
            ListViewItem list_item = new ListViewItem();
            list_item.Tag = entered_Record;
            list_item.Text = entered_Record.firstName;
            list_item.SubItems.Add(entered_Record.lastName);
            list_item.SubItems.Add(Regex.Replace(entered_Record.Phone, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3"));
            list.Items.Add(list_item);
        }

       
          //  Modifies an existing record in List.
        
        private void ModifyListViewItem(ListView list, RebateRecord entered_Record)
        {
            list.SelectedItems[0].Tag = entered_Record;
            list.SelectedItems[0].SubItems[0].Text = entered_Record.firstName;
            list.SelectedItems[0].SubItems[1].Text = entered_Record.lastName;
            list.SelectedItems[0].SubItems[2].Text = Regex.Replace(entered_Record.Phone, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
        }

       //CLEARS FORM WHEN CANCEL CLICKED
        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
       
        private void ClearForm()
        {
            // clear all fields
            firstName.Clear();
            Minitial.Clear();
            lastName.Clear();
            Address1.Clear();
            Address2.Clear();
            City.Clear();
            State.SelectedItem = null;
            Zip.Clear();
            Gender.SelectedItem = null; ;
            Phone.Clear();
            Email.Clear();
            Proof.SelectedItem = null;
            Date.Value = DateTime.Today;

            // clear errors
            FieldError.SetError(firstName, "");
            FieldError.SetError(Minitial, "");
            FieldError.SetError(lastName, "");
            FieldError.SetError(Address1, "");
            FieldError.SetError(Address2, "");
            FieldError.SetError(City, "");
            FieldError.SetError(State, "");
            FieldError.SetError(Zip, "");
            FieldError.SetError(Gender, "");
            FieldError.SetError(Phone, "");
            FieldError.SetError(Email, "");
            FieldError.SetError(Proof, "");
            FieldError.SetError(Date, "");

            
            firstName.Select();
            SetAddMode();        
        }

       
        // Removes record from ListView when delete is pressed and writes to file.
        
        private void Delete_Click(object sender, EventArgs e)
        {
            deletedRecord = (RebateRecord)RebateList.SelectedItems[0].Tag;
            deletedRecordIndex = RebateList.SelectedItems[0].Index;
            RebateList.SelectedItems[0].Remove();
            RebateFileHandler rebate_File = new RebateFileHandler();
            rebate_File.WriteRebateList(RebateList);
            UndoMenuItem.Enabled = true;
            ClearForm();

            Status_label.Text = "Deleted Rebate";
        }

       // Counts Backspaces and lets user move to next Field and enter key acts as submit
        private void RebateEntryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TAB key to next field
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (Save.Enabled)
                {
                    Save.PerformClick();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
            
            if(e.KeyChar == (char)Keys.Back)
            {
                backSpace_count++;
            }
        }

       
        //   When List is clicked or double clicked, change to MODIFY mode.
        private void RebateList_Click(object sender, EventArgs e)
        {
            SetModifyMode();
        }

       
        private void RebateList_DoubleClick(object sender, EventArgs e)
        {
            SetModifyMode();
        }


        

        private void RebateList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                SetModifyMode();
                SendKeys.Send("+{TAB}");
            }
        }

      
          
        private void SetAddMode()
        {
            curr_Mode = ADD;
            Status_label.Text = "Adding New Rebate";
            Save.Text = "&Save";
            Save.Enabled = false;
            Delete.Enabled = false;
            start_time = DateTime.MinValue;
            backSpace_count = 0;
        }

       
       
        private void SetModifyMode()
        {
            if (RebateList.SelectedItems.Count == 0)
                return;
            ListViewItem list_item = RebateList.SelectedItems[0];
            RebateRecord rebate_list_item = (RebateRecord)list_item.Tag;
   
            ClearForm();

            firstName.Text = rebate_list_item.firstName;
            Minitial.Text = rebate_list_item.middleInitial;
            lastName.Text = rebate_list_item.lastName;
            Address1.Text = rebate_list_item.Address1;
            Address2.Text = rebate_list_item.Address2;
            City.Text = rebate_list_item.City;
            State.SelectedItem = rebate_list_item.State;
            Zip.Text = rebate_list_item.Zip;
            Gender.SelectedItem = rebate_list_item.Gender;
            Phone.Text = rebate_list_item.Phone;
            Email.Text = rebate_list_item.Email;
            Proof.SelectedItem = rebate_list_item.Proof;
            Date.Value = rebate_list_item.Date;

            curr_Mode = MODIFY;
            Status_label.Text = "Modifying Existing Rebate";
            Save.Text = "Update";

            Delete.Enabled = true;

            CanSave();
           
            Save.Enabled = false;  
        }

        
           
       
    
           //EXIT APPLICATION
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
       
       

        // Error message if any field is not valid 
        private void firstName_validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextField(firstName.Text))
            {
                FieldError.SetError(firstName, "Required Field");
            }
            else
            {
                FieldError.SetError(firstName, "");
            }
        }

        private void middleInitial_validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Minitial.Text) && !Validator.ValidateInitial(Minitial.Text))
            {
                Minitial.ForeColor = Color.Red;
                FieldError.SetError(Minitial, "Invalid Character");
            }
            else
            {
                Minitial.ForeColor = Color.Black;
                FieldError.SetError(Minitial, "");
            }
        }

        private void lastName_validate(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextField(lastName.Text))
            {
                FieldError.SetError(lastName, "Required Field");
            }
            else
            {
                FieldError.SetError(lastName, "");
            }
        }

        private void Address1_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextField(Address1.Text))
            {
                FieldError.SetError(Address1, "Required Field");
            }
            else
            {
                FieldError.SetError(Address1, "");
            }
        }

        private void City_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateTextField(City.Text))
            {
                FieldError.SetError(City, "Required Field");
            }
            else
            {
                FieldError.SetError(City, "");
            }
        }

        private void State_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateComboBox(State.SelectedItem))
            {
                FieldError.SetError(State, "Required Field");
            }
            else
            {
                FieldError.SetError(State, "");
            }
        }

        private void Zip_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateZipCode(Zip.Text))
            {
                if (string.IsNullOrWhiteSpace(Zip.Text.Remove(5, 1).Trim()))
                {
                    FieldError.SetError(Zip, "Required Field");
                }
                else
                {
                    Zip.ForeColor = Color.Red;
                    FieldError.SetError(Zip, "Invalid Zip Code");
                }
            }
            else
            {
                Zip.ForeColor = Color.Black;
                FieldError.SetError(Zip, "");
            }
        }

        private void Gender_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateComboBox(Gender.SelectedItem))
            {
                FieldError.SetError(Gender, "Required Field");
            }
            else
            {
                FieldError.SetError(Gender, "");
            }
        }

        private void Phone_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidatePhoneNumber(Phone.Text))
            {
                if (string.IsNullOrWhiteSpace(Phone.Text.Replace("(", "")
                    .Replace(")", "").Replace("-", "").Trim()))
                {
                    FieldError.SetError(Phone, "Required Field");
                }
                else
                {
                    Phone.ForeColor = Color.Red;
                    FieldError.SetError(Phone, "Invalid Phone Number");
                }
            }
            else
            {
                Email.ForeColor = Color.Black;
                FieldError.SetError(Email, "");
            }
        }

        private void Email_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateEmailAddress(Email.Text))
            {
                if (string.IsNullOrWhiteSpace(Email.Text))
                {
                    FieldError.SetError(Email, "Required Field");
                }
                else
                {
                    Email.ForeColor = Color.Red;
                    FieldError.SetError(Email, "Invalid Email Address");
                }
            }
            else
            {
                Email.ForeColor = Color.Black;
                FieldError.SetError(Email, "");
            }
        }

        private void Proof_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateComboBox(Proof.SelectedItem))
            {
                FieldError.SetError(Proof, "Required Field");
            }
            else
            {
                FieldError.SetError(Proof, "");
            }
        }

        private void Date_Validated(object sender, EventArgs e)
        {
            if (!Validator.ValidateDate(Date.Value))
            {
                FieldError.SetError(Date, "Cannot Select Future Date");
            }
            else
            {
                FieldError.SetError(Date, "");
            }
        }
    }
}
