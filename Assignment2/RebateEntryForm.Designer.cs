using System;
namespace Asg2_axk180196
{
    partial class RebateEntryForm
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebateEntryForm));
            this.firstName = new System.Windows.Forms.TextBox();
            this.Fname_label = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Lname_label = new System.Windows.Forms.Label();
            this.Minitial = new System.Windows.Forms.TextBox();
            this.Minitial_label = new System.Windows.Forms.Label();
            this.Address1 = new System.Windows.Forms.TextBox();
            this.Address1_label = new System.Windows.Forms.Label();
            this.Address2 = new System.Windows.Forms.TextBox();
            this.Address2_label = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.City_label = new System.Windows.Forms.Label();
            this.State_label = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.MaskedTextBox();
            this.Zip_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Proof = new System.Windows.Forms.ComboBox();
            this.Proof_label = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Date_label = new System.Windows.Forms.Label();
            this.RebateList = new System.Windows.Forms.ListView();
            this.FnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.UndoMenuItem = new System.Windows.Forms.MenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FieldBox = new System.Windows.Forms.GroupBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.FieldError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Status.SuspendLayout();
            this.FieldBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FieldError)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            resources.ApplyResources(this.firstName, "firstName");
            this.firstName.Name = "firstName";
            this.firstName.TextChanged += new System.EventHandler(this.FieldChanged);
            this.firstName.Validated += new System.EventHandler(this.firstName_validated);
            // 
            // Fname_label
            // 
            resources.ApplyResources(this.Fname_label, "Fname_label");
            this.Fname_label.Name = "Fname_label";
            // 
            // lastName
            // 
            resources.ApplyResources(this.lastName, "lastName");
            this.lastName.Name = "lastName";
            this.lastName.TextChanged += new System.EventHandler(this.FieldChanged);
            this.lastName.Validated += new System.EventHandler(this.lastName_validate);
            // 
            // Lname_label
            // 
            resources.ApplyResources(this.Lname_label, "Lname_label");
            this.Lname_label.Name = "Lname_label";
            // 
            // Minitial
            // 
            resources.ApplyResources(this.Minitial, "Minitial");
            this.Minitial.Name = "Minitial";
            this.Minitial.TextChanged += new System.EventHandler(this.FieldChanged);
            this.Minitial.Validated += new System.EventHandler(this.middleInitial_validated);
            // 
            // Minitial_label
            // 
            resources.ApplyResources(this.Minitial_label, "Minitial_label");
            this.Minitial_label.Name = "Minitial_label";
            // 
            // Address1
            // 
            resources.ApplyResources(this.Address1, "Address1");
            this.Address1.Name = "Address1";
            this.Address1.TextChanged += new System.EventHandler(this.FieldChanged);
            this.Address1.Validated += new System.EventHandler(this.Address1_Validated);
            // 
            // Address1_label
            // 
            resources.ApplyResources(this.Address1_label, "Address1_label");
            this.Address1_label.Name = "Address1_label";
            // 
            // Address2
            // 
            resources.ApplyResources(this.Address2, "Address2");
            this.Address2.Name = "Address2";
            this.Address2.TextChanged += new System.EventHandler(this.FieldChanged);
            // 
            // Address2_label
            // 
            resources.ApplyResources(this.Address2_label, "Address2_label");
            this.Address2_label.Name = "Address2_label";
            // 
            // City
            // 
            resources.ApplyResources(this.City, "City");
            this.City.Name = "City";
            this.City.TextChanged += new System.EventHandler(this.FieldChanged);
            this.City.Validated += new System.EventHandler(this.City_Validated);
            // 
            // City_label
            // 
            resources.ApplyResources(this.City_label, "City_label");
            this.City_label.Name = "City_label";
            // 
            // State_label
            // 
            resources.ApplyResources(this.State_label, "State_label");
            this.State_label.Name = "State_label";
            // 
            // Zip
            // 
            resources.ApplyResources(this.Zip, "Zip");
            this.Zip.Name = "Zip";
            this.Zip.TextChanged += new System.EventHandler(this.FieldChanged);
            this.Zip.Validated += new System.EventHandler(this.Zip_Validated);
            // 
            // Zip_label
            // 
            resources.ApplyResources(this.Zip_label, "Zip_label");
            this.Zip_label.Name = "Zip_label";
            // 
            // Gender_label
            // 
            resources.ApplyResources(this.Gender_label, "Gender_label");
            this.Gender_label.Name = "Gender_label";
            // 
            // Phone
            // 
            resources.ApplyResources(this.Phone, "Phone");
            this.Phone.Name = "Phone";
            this.Phone.TextChanged += new System.EventHandler(this.FieldChanged);
            this.Phone.Validated += new System.EventHandler(this.Phone_Validated);
            // 
            // Phone_label
            // 
            resources.ApplyResources(this.Phone_label, "Phone_label");
            this.Phone_label.Name = "Phone_label";
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.TextChanged += new System.EventHandler(this.FieldChanged);
            this.Email.Validated += new System.EventHandler(this.Email_Validated);
            // 
            // Email_label
            // 
            resources.ApplyResources(this.Email_label, "Email_label");
            this.Email_label.Name = "Email_label";
            // 
            // Proof
            // 
            this.Proof.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Proof.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Proof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Proof, "Proof");
            this.Proof.FormattingEnabled = true;
            this.Proof.Items.AddRange(new object[] {
            resources.GetString("Proof.Items"),
            resources.GetString("Proof.Items1")});
            this.Proof.Name = "Proof";
            this.Proof.SelectedValueChanged += new System.EventHandler(this.FieldChanged);
            this.Proof.Validated += new System.EventHandler(this.Proof_Validated);
            // 
            // Proof_label
            // 
            resources.ApplyResources(this.Proof_label, "Proof_label");
            this.Proof_label.Name = "Proof_label";
            // 
            // Date
            // 
            this.Date.Checked = false;
            resources.ApplyResources(this.Date, "Date");
            this.Date.Name = "Date";
            this.Date.ValueChanged += new System.EventHandler(this.Date_Changed);
            this.Date.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Date_PreviewKeyDown);
            this.Date.Validated += new System.EventHandler(this.Date_Validated);
            // 
            // Date_label
            // 
            resources.ApplyResources(this.Date_label, "Date_label");
            this.Date_label.Name = "Date_label";
            // 
            // RebateList
            // 
            this.RebateList.AllowColumnReorder = true;
            this.RebateList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FnameHeader,
            this.LnameHeader,
            this.PhoneHeader});
            this.RebateList.FullRowSelect = true;
            this.RebateList.GridLines = true;
            this.RebateList.HideSelection = false;
            resources.ApplyResources(this.RebateList, "RebateList");
            this.RebateList.MultiSelect = false;
            this.RebateList.Name = "RebateList";
            this.RebateList.UseCompatibleStateImageBehavior = false;
            this.RebateList.View = System.Windows.Forms.View.Details;
            this.RebateList.Click += new System.EventHandler(this.RebateList_Click);
            this.RebateList.DoubleClick += new System.EventHandler(this.RebateList_DoubleClick);
            this.RebateList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RebateList_KeyDown);
            // 
            // FnameHeader
            // 
            resources.ApplyResources(this.FnameHeader, "FnameHeader");
            // 
            // LnameHeader
            // 
            resources.ApplyResources(this.LnameHeader, "LnameHeader");
            // 
            // PhoneHeader
            // 
            resources.ApplyResources(this.PhoneHeader, "PhoneHeader");
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ExitMenuItem});
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 0;
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.UndoMenuItem});
            resources.ApplyResources(this.menuItem2, "menuItem2");
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Index = 0;
            resources.ApplyResources(this.UndoMenuItem, "UndoMenuItem");
            // 
            // Status
            // 
            this.Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_label});
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // Status_label
            // 
            this.Status_label.Name = "Status_label";
            resources.ApplyResources(this.Status_label, "Status_label");
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TabStop = false;
            // 
            // State
            // 
            this.State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.State, "State");
            this.State.FormattingEnabled = true;
            this.State.Items.AddRange(new object[] {
            resources.GetString("State.Items"),
            resources.GetString("State.Items1"),
            resources.GetString("State.Items2"),
            resources.GetString("State.Items3"),
            resources.GetString("State.Items4"),
            resources.GetString("State.Items5"),
            resources.GetString("State.Items6"),
            resources.GetString("State.Items7"),
            resources.GetString("State.Items8"),
            resources.GetString("State.Items9"),
            resources.GetString("State.Items10"),
            resources.GetString("State.Items11"),
            resources.GetString("State.Items12"),
            resources.GetString("State.Items13"),
            resources.GetString("State.Items14"),
            resources.GetString("State.Items15"),
            resources.GetString("State.Items16"),
            resources.GetString("State.Items17"),
            resources.GetString("State.Items18"),
            resources.GetString("State.Items19"),
            resources.GetString("State.Items20"),
            resources.GetString("State.Items21"),
            resources.GetString("State.Items22"),
            resources.GetString("State.Items23"),
            resources.GetString("State.Items24"),
            resources.GetString("State.Items25"),
            resources.GetString("State.Items26"),
            resources.GetString("State.Items27"),
            resources.GetString("State.Items28"),
            resources.GetString("State.Items29"),
            resources.GetString("State.Items30"),
            resources.GetString("State.Items31"),
            resources.GetString("State.Items32"),
            resources.GetString("State.Items33"),
            resources.GetString("State.Items34"),
            resources.GetString("State.Items35"),
            resources.GetString("State.Items36"),
            resources.GetString("State.Items37"),
            resources.GetString("State.Items38"),
            resources.GetString("State.Items39"),
            resources.GetString("State.Items40"),
            resources.GetString("State.Items41"),
            resources.GetString("State.Items42"),
            resources.GetString("State.Items43"),
            resources.GetString("State.Items44"),
            resources.GetString("State.Items45"),
            resources.GetString("State.Items46"),
            resources.GetString("State.Items47"),
            resources.GetString("State.Items48"),
            resources.GetString("State.Items49")});
            this.State.Name = "State";
            this.State.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            this.State.Validated += new System.EventHandler(this.State_Validated);
            // 
            // Gender
            // 
            this.Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Gender, "Gender");
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            resources.GetString("Gender.Items"),
            resources.GetString("Gender.Items1")});
            this.Gender.Name = "Gender";
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.FieldChanged);
            this.Gender.Validated += new System.EventHandler(this.Gender_Validated);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TabStop = false;
            // 
            // FieldBox
            // 
            resources.ApplyResources(this.FieldBox, "FieldBox");
            this.FieldBox.Controls.Add(this.State);
            this.FieldBox.Controls.Add(this.Fname_label);
            this.FieldBox.Controls.Add(this.Date);
            this.FieldBox.Controls.Add(this.firstName);
            this.FieldBox.Controls.Add(this.Proof);
            this.FieldBox.Controls.Add(this.Minitial_label);
            this.FieldBox.Controls.Add(this.Phone);
            this.FieldBox.Controls.Add(this.Phone_label);
            this.FieldBox.Controls.Add(this.Minitial);
            this.FieldBox.Controls.Add(this.Date_label);
            this.FieldBox.Controls.Add(this.Lname_label);
            this.FieldBox.Controls.Add(this.lastName);
            this.FieldBox.Controls.Add(this.Proof_label);
            this.FieldBox.Controls.Add(this.Address1_label);
            this.FieldBox.Controls.Add(this.Address1);
            this.FieldBox.Controls.Add(this.Email);
            this.FieldBox.Controls.Add(this.Email_label);
            this.FieldBox.Controls.Add(this.Address2);
            this.FieldBox.Controls.Add(this.Address2_label);
            this.FieldBox.Controls.Add(this.City_label);
            this.FieldBox.Controls.Add(this.City);
            this.FieldBox.Controls.Add(this.textBox1);
            this.FieldBox.Controls.Add(this.State_label);
            this.FieldBox.Controls.Add(this.Gender);
            this.FieldBox.Controls.Add(this.Gender_label);
            this.FieldBox.Controls.Add(this.Zip_label);
            this.FieldBox.Controls.Add(this.Zip);
            this.FieldBox.Controls.Add(this.textBox2);
            this.FieldBox.Controls.Add(this.textBox3);
            this.FieldBox.Name = "FieldBox";
            this.FieldBox.TabStop = false;
            // 
            // ButtonPanel
            // 
            resources.ApplyResources(this.ButtonPanel, "ButtonPanel");
            this.ButtonPanel.Controls.Add(this.Delete);
            this.ButtonPanel.Controls.Add(this.Save);
            this.ButtonPanel.Controls.Add(this.Cancel);
            this.ButtonPanel.Controls.Add(this.RebateList);
            this.ButtonPanel.Name = "ButtonPanel";
            // 
            // FieldError
            // 
            this.FieldError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FieldError.ContainerControl = this;
            // 
            // RebateEntryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.FieldBox);
            this.KeyPreview = true;
            this.Menu = this.MainMenu;
            this.Name = "RebateEntryForm";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateEntryForm_KeyPress);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.FieldBox.ResumeLayout(false);
            this.FieldBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FieldError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label Fname_label;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label Lname_label;
        private System.Windows.Forms.TextBox Minitial;
        private System.Windows.Forms.Label Minitial_label;
        private System.Windows.Forms.TextBox Address1;
        private System.Windows.Forms.Label Address1_label;
        private System.Windows.Forms.TextBox Address2;
        private System.Windows.Forms.Label Address2_label;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label State_label;
        private System.Windows.Forms.MaskedTextBox Zip;
        private System.Windows.Forms.Label Zip_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.ComboBox Proof;
        private System.Windows.Forms.Label Proof_label;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.ListView RebateList;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel Status_label;
        private System.Windows.Forms.ColumnHeader FnameHeader;
        private System.Windows.Forms.ColumnHeader LnameHeader;
        private System.Windows.Forms.ColumnHeader PhoneHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox State;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuItem ExitMenuItem;
        private System.Windows.Forms.MenuItem UndoMenuItem;
        private System.Windows.Forms.GroupBox FieldBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.ErrorProvider FieldError;
    }
}

