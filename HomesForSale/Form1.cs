using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyManager;

namespace HomesForSale
{
    
    public partial class 
        Form1 : Form
    {
        private int id;
        private string file;
        private EstateController estateController;

        public Form1()
        {
            Design();
            InitializeComponents();
        }
 
        private void InitializeComponents()
        {
            file = null;
            id = 1;
            estateController = new EstateController();
            DeleteButton.Enabled = false;
            ChangeButton.Enabled = false;
            InfoButton.Enabled = false;
            CountryOption.DataSource = Enum.GetValues(typeof(Countries));
            LegalFormOption.DataSource = Enum.GetValues(typeof(LegalForm));

            TypeOption.DropDownStyle = ComboBoxStyle.DropDownList;
            CountryOption.DropDownStyle = ComboBoxStyle.DropDownList;
            LegalFormOption.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void rbResidental_CheckedChanged(object sender, EventArgs e){TypeOption.DataSource = Enum.GetValues(typeof(ResidentalOption));}


      
        ///if commercial radiobutton is checked, the list of type will fill with commercial types.
    
        private void rdCommercial_CheckedChanged(object sender, EventArgs e){TypeOption.DataSource = Enum.GetValues(typeof(CommericalOption));}

       
        /// if any object is selected in the view the change and delete buttons will be enabled.
        
        private void lvProperties_SelectedIndexChanged(object sender, EventArgs e){DeleteButton.Enabled = true; ChangeButton.Enabled = true; InfoButton.Enabled = true; }
        
        ///method to add a object to the list in listmanager and add to the view. 
        ///creates a Property and uses the switch case to give the property a value. 
        private void btnAdd_Click(object sender, EventArgs e){

            Property property;
            string typeOfProperty = TypeOption.Text;

            switch (typeOfProperty)
            {
                case "Apartment":
                    property = new Apartment();
                    break;

                case "House":
                    property = new House();
                    break;

                case "Shop":
                    property = new Shop();
                    break;

                case "Townhouse":
                    property = new Townhouse();
                    break;

                case "Warehouse":
                    property = new Warehouse();
                    break;

                case "Villa":
                    property = new Villa();
                    break;
                default:
                    typeOfProperty = TypeOption.Text;
                    return;
            }
            property.Id = id;
            AddProperty(property);
            estateController.Add(property);
            id++;
            test(); // check how many objects in listmanager.
            fillList(); 
        }

        /// method that adds the values to the property, based on input from gui.
        
        private void AddProperty(Property property)
        {
            Address address = new Address
            {
                Country = CountryOption.Text,
                City = CityName.Text,
                Street = StreetName.Text,
                ZipCode = ZipCodeNumber.Text
            };

            property.Address = address;
            property.LegalForm = LegalFormOption.Text;
            property.Type = TypeOption.Text;

            if (rbResidentalutton.Checked)
            {
                property.UseForm= rbResidentalutton.Text;
            }
            else
            {
                property.UseForm = CommerciaButtonl.Text;
            }
        }

        /// button to delete a selected object in the viewlist, also gets deleted in the list in listmanager.
     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            estateController.DeleteAt(listoption.SelectedIndices[0]);

            fillList();
            DeleteButton.Enabled = false;
            ChangeButton.Enabled = false;
            test();
        }

        /// method for changing an objects values, and refresh the list and viewlist with the new values.

        private void btnChange_Click(object sender, EventArgs e)
        {

            Property property;
            string typeOfProperty = TypeOption.Text;
            int selectedObjectId = Int32.Parse(listoption.SelectedItems[0].SubItems[0].Text);

            switch (typeOfProperty)
            {
                case "Apartment":
                    property = new Apartment();
                    break;

                case "House":
                    property = new House();

                    break;

                case "Shop":
                    property = new Shop();

                    break;

                case "TownHouse":
                    property = new Townhouse();

                    break;

                case "Warehouse":
                    property = new Warehouse();

                    break;

                case "Villa":
                    property = new Villa();
                    property.Id = id;
                    break;
                default:
                    typeOfProperty = TypeOption.Text;
                    return;
            }
            property.Id = selectedObjectId;
            AddProperty(property);
           
            test();
            ChangeButton.Enabled = false;
            DeleteButton.Enabled = false;
            for(int i=0; i< estateController.Count; i++)
            {
                if (estateController.GetAt(i).Id == selectedObjectId)
                    estateController.ChangeAt(property, i);
            }
            fillList();
        }

        /// method that iterates the listmanager, and adds the objects to the listview.
        private void fillList()
        {
            listoption.Items.Clear();
            for(int i = 0; i < estateController.Count; i++)
            {
                addPropertyToListView(estateController.GetAt(i));
            }
        }

        private void addPropertyToListView(Property property)
        {
            ListViewItem lv = new ListViewItem(property.Id.ToString());
            lv.SubItems.Add(property.UseForm);
            lv.SubItems.Add(property.Type);
            lv.SubItems.Add(property.LegalForm);
            lv.SubItems.Add(property.Address.Country);
            lv.SubItems.Add(property.Address.City);
            lv.SubItems.Add(property.Address.ZipCode);
            lv.SubItems.Add(property.Address.Street);

            listoption.Items.Add(lv);
        }
        ///displays the number of objects that exist in the list
        private void test()
        {
            label1.Text = estateController.Count.ToString();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1430, 678);
            this.Name = "HomesForSales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       


    }
}
