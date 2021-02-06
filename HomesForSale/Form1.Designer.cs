
namespace HomesForSale
{
    //This Class DEsign the form of the program, Orginize labels,buttons and panels.
    //Fatima &Talal.
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

       
        /// Clean up any resources being used.
       
        protected override void Dispose(bool clear)
        {
            if (clear && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(clear);
        }

          #region Windows Form Designer generated code

        
        private void Design()
        {
            this.Mainpanel = new System.Windows.Forms.Panel();
            //RadioButton
            this.CommerciaButtonl = new System.Windows.Forms.RadioButton();
            this.rbResidentalutton = new System.Windows.Forms.RadioButton();
            //ComboBox
            this.CountryOption = new System.Windows.Forms.ComboBox();
            this.LegalFormOption = new System.Windows.Forms.ComboBox();
            this.TypeOption = new System.Windows.Forms.ComboBox();
            //TextBox
            this.CityName = new System.Windows.Forms.TextBox();
            this.ZipCodeNumber = new System.Windows.Forms.TextBox();
            this.StreetName = new System.Windows.Forms.TextBox();
            //Label
            this.Typelebel = new System.Windows.Forms.Label();
            this.LegalFormLebel = new System.Windows.Forms.Label();
            this.CountryLebel = new System.Windows.Forms.Label();
            //List
            this.listoption = new System.Windows.Forms.ListView();
            this.IDch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResComch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Legalformch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Countrych = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Citych = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zipcodech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStreetch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            // MainButton
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();

            this.InfoButton = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.Citylabel = new System.Windows.Forms.Label();
            this.Typelabel = new System.Windows.Forms.Label();
            this.CitySearch = new System.Windows.Forms.TextBox();
            this.TypeSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mainpanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // Country
            this.CountryOption.FormattingEnabled = true;
            this.CountryOption.Location = new System.Drawing.Point(123, 63);
            this.CountryOption.Name = "cdCountry";
            this.CountryOption.Size = new System.Drawing.Size(102, 21);
            this.CountryOption.TabIndex = 0;
            this.CountryOption.Text = "Country";
            // LegalForm
            this.LegalFormOption.FormattingEnabled = true;
            this.LegalFormOption.Location = new System.Drawing.Point(123, 94);
            this.LegalFormOption.Name = "cdLegalForm";
            this.LegalFormOption.Size = new System.Drawing.Size(102, 21);
            this.LegalFormOption.TabIndex = 1;
            this.LegalFormOption.Text = "Legal Form";
            // City
            this.CityName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CityName.Location = new System.Drawing.Point(28, 162);
            this.CityName.Name = "tbCity";
            this.CityName.Size = new System.Drawing.Size(197, 20);
            this.CityName.TabIndex = 2;
            this.CityName.Text = "City";
            // ZipCode
            this.ZipCodeNumber.Location = new System.Drawing.Point(28, 188);
            this.ZipCodeNumber.Name = "tbZipCode";
            this.ZipCodeNumber.Size = new System.Drawing.Size(197, 20);
            this.ZipCodeNumber.TabIndex = 3;
            this.ZipCodeNumber.Text = "Zip Code";
            // Street
            this.StreetName.Location = new System.Drawing.Point(28, 214);
            this.StreetName.Name = "tbStreet";
            this.StreetName.Size = new System.Drawing.Size(197, 20);
            this.StreetName.TabIndex = 4;
            this.StreetName.Text = "Street";
            // MainPanel
            this.Mainpanel.Controls.Add(this.Typelebel);
            this.Mainpanel.Controls.Add(this.TypeOption);
            this.Mainpanel.Controls.Add(this.CommerciaButtonl);
            this.Mainpanel.Controls.Add(this.rbResidentalutton);
            this.Mainpanel.Controls.Add(this.LegalFormLebel);
            this.Mainpanel.Controls.Add(this.CountryLebel);
            this.Mainpanel.Controls.Add(this.StreetName);
            this.Mainpanel.Controls.Add(this.ZipCodeNumber);
            this.Mainpanel.Controls.Add(this.CountryOption);
            this.Mainpanel.Controls.Add(this.CityName);
            this.Mainpanel.Controls.Add(this.LegalFormOption);
            this.Mainpanel.Location = new System.Drawing.Point(300, 50);
            this.Mainpanel.Name = "panel1";
            this.Mainpanel.Size = new System.Drawing.Size(230, 240);
            this.Mainpanel.TabIndex = 5;
            // Type
            this.Typelebel.AutoSize = true;
            this.Typelebel.Location = new System.Drawing.Point(25, 5);
            this.Typelebel.Name = "lblType";
            this.Typelebel.Size = new System.Drawing.Size(67, 13);
            this.Typelebel.TabIndex = 10;
            this.Typelebel.Text = "Select:";
            // TypeOpttion
            this.TypeOption.FormattingEnabled = true;
            this.TypeOption.Location = new System.Drawing.Point(123, 122);
            this.TypeOption.Name = "cbOption";
            this.TypeOption.Size = new System.Drawing.Size(102, 21);
            this.TypeOption.TabIndex = 9;
            // Commercial
            this.CommerciaButtonl.AutoSize = true;
            this.CommerciaButtonl.Location = new System.Drawing.Point(123, 29);
            this.CommerciaButtonl.Name = "rdCommercial";
            this.CommerciaButtonl.Size = new System.Drawing.Size(79, 17);
            this.CommerciaButtonl.TabIndex = 8;
            this.CommerciaButtonl.Text = "Commercial";
            this.CommerciaButtonl.UseVisualStyleBackColor = true;
            this.CommerciaButtonl.CheckedChanged += new System.EventHandler(this.rdCommercial_CheckedChanged);
            // Residental
            this.rbResidentalutton.AutoSize = true;
            this.rbResidentalutton.Location = new System.Drawing.Point(28, 29);
            this.rbResidentalutton.Name = "rbResidental";
            this.rbResidentalutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbResidentalutton.Size = new System.Drawing.Size(75, 17);
            this.rbResidentalutton.TabIndex = 7;
            this.rbResidentalutton.Text = "Residental";
            this.rbResidentalutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbResidentalutton.UseVisualStyleBackColor = true;
            this.rbResidentalutton.CheckedChanged += new System.EventHandler(this.rbResidental_CheckedChanged);
            // LegalForm
            this.LegalFormLebel.AutoSize = true;
            this.LegalFormLebel.Location = new System.Drawing.Point(625, 97);
            this.LegalFormLebel.Name = "lblLegalForm";
            this.LegalFormLebel.Size = new System.Drawing.Size(92, 13);
            this.LegalFormLebel.TabIndex = 6;
            this.LegalFormLebel.Text = "Select Legal form:";
            // Cuntry
            this.CountryLebel.AutoSize = true;
            this.CountryLebel.Location = new System.Drawing.Point(25, 66);
            this.CountryLebel.Name = "lblCountry";
            this.CountryLebel.Size = new System.Drawing.Size(79, 13);
            this.CountryLebel.TabIndex = 5;
            this.CountryLebel.Text = "Select Country:";
            // List
            this.listoption.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDch,
            this.ResComch,
            this.Typech,
            this.Legalformch,
            this.Countrych,
            this.Citych,
            this.Zipcodech,
            this.cStreetch});
            this.listoption.FullRowSelect = true;
            this.listoption.Location = new System.Drawing.Point(75, 330);
            this.listoption.Name = "lvProperties";
            this.listoption.Size = new System.Drawing.Size(800, 150);
            this.listoption.TabIndex = 6;
            this.listoption.UseCompatibleStateImageBehavior = false;
            this.listoption.View = System.Windows.Forms.View.Details;
            this.listoption.SelectedIndexChanged += new System.EventHandler(this.lvProperties_SelectedIndexChanged);
            // 
            // ID
            // 
            this.IDch.Text = "ID";
            this.IDch.Width = 25;
            // 
            // ResCom
            // 
            this.ResComch.Text = "Res/Com";
            this.ResComch.Width = 77;
            // 
            // Type
            // 
            this.Typech.Text = "Type";
            this.Typech.Width = 59;
            // 
            // Legalform
            // 
            this.Legalformch.Text = "LegalForm";
            this.Legalformch.Width = 80;
            // 
            // Country
            // 
            this.Countrych.Text = "Country";
            this.Countrych.Width = 102;
            // 
            // City
            // 
            this.Citych.Text = "City";
            this.Citych.Width = 91;
            // 
            // Zipcode
            // 
            this.Zipcodech.Text = "Zip Code";
            this.Zipcodech.Width = 63;
            // Street
            this.cStreetch.Text = "Street";
            this.cStreetch.Width = 157;
            // Add
            this.AddButton.Location = new System.Drawing.Point(120, 81);
            this.AddButton.Name = "btnAdd";
            this.AddButton.Size = new System.Drawing.Size(160, 42);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.btnAdd_Click);
            // Delete
            this.DeleteButton.Location = new System.Drawing.Point(120, 150);
            this.DeleteButton.Name = "btnDelete";
            this.DeleteButton.Size = new System.Drawing.Size(160, 45);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.btnDelete_Click);
            // Change
            this.ChangeButton.Location = new System.Drawing.Point(120, 225);
            this.ChangeButton.Name = "btnChange";
            this.ChangeButton.Size = new System.Drawing.Size(160, 46);
            this.ChangeButton.TabIndex = 10;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.btnChange_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 485);
            this.label2.Name = "lblTotal";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total: ";
                 

            // btnInfo
            this.InfoButton.Location = new System.Drawing.Point(450, 300);
            this.InfoButton.Name = "Info";
            this.InfoButton.Size = new System.Drawing.Size(75, 23);
            this.InfoButton.TabIndex = 13;
            this.InfoButton.Text = "show info";
            this.InfoButton.UseVisualStyleBackColor = true;
            
            // label3
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Location = new System.Drawing.Point(58, 16);
            this.Searchlabel.Name = "label3";
            this.Searchlabel.Size = new System.Drawing.Size(126, 26);
            this.Searchlabel.TabIndex = 15;
            this.Searchlabel.Text = " To search for an object, \r\nadd City and Type below";
            // label4
            this.Citylabel.AutoSize = true;
            this.Citylabel.Location = new System.Drawing.Point(13, 63);
            this.Citylabel.Name = "label4";
            this.Citylabel.Size = new System.Drawing.Size(30, 13);
            this.Citylabel.TabIndex = 16;
            this.Citylabel.Text = "City :";
            // label5
            this.Typelabel.AutoSize = true;
            this.Typelabel.Location = new System.Drawing.Point(9, 93);
            this.Typelabel.Name = "label5";
            this.Typelabel.Size = new System.Drawing.Size(34, 13);
            this.Typelabel.TabIndex = 17;
            this.Typelabel.Text = "Type:";
            // CitySearch
            this.CitySearch.Location = new System.Drawing.Point(49, 60);
            this.CitySearch.Name = "tbCitySearch";
            this.CitySearch.Size = new System.Drawing.Size(100, 20);
            this.CitySearch.TabIndex = 18;
            // TypeSearch
            this.TypeSearch.Location = new System.Drawing.Point(49, 90);
            this.TypeSearch.Name = "tbTypeSearch";
            this.TypeSearch.Size = new System.Drawing.Size(100, 20);
            this.TypeSearch.TabIndex = 19;
            // groupBox1
            this.groupBox1.Controls.Add(this.CitySearch);
            this.groupBox1.Controls.Add(this.Searchlabel);
            this.groupBox1.Controls.Add(this.Typelabel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.TypeSearch);
            this.groupBox1.Controls.Add(this.Citylabel);
            this.groupBox1.Location = new System.Drawing.Point(650, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            
            // Form1

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.listoption);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForSales";
            this.Text = "HomeForSales";
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryOption;
        private System.Windows.Forms.ComboBox LegalFormOption;
        private System.Windows.Forms.TextBox CityName;
        private System.Windows.Forms.TextBox ZipCodeNumber;
        private System.Windows.Forms.TextBox StreetName;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Label LegalFormLebel;
        private System.Windows.Forms.Label CountryLebel;
        private System.Windows.Forms.RadioButton CommerciaButtonl;
        private System.Windows.Forms.RadioButton rbResidentalutton;
        private System.Windows.Forms.ListView listoption;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ColumnHeader IDch;
        private System.Windows.Forms.ColumnHeader Typech;
        private System.Windows.Forms.ColumnHeader Legalformch;
        private System.Windows.Forms.ColumnHeader Countrych;
        private System.Windows.Forms.ColumnHeader Citych;
        private System.Windows.Forms.ColumnHeader Zipcodech;
        private System.Windows.Forms.ColumnHeader cStreetch;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Typelebel;
        private System.Windows.Forms.ComboBox TypeOption;
        private System.Windows.Forms.ColumnHeader ResComch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.TextBox CitySearch;
        private System.Windows.Forms.TextBox TypeSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

