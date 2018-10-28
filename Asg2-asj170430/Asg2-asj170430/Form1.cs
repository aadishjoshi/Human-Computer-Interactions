using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_asj170430
{
    public partial class Form1 : Form
    {
        static int backSpace = 0;
        GetterSetterClass data = new GetterSetterClass();
        dataOperator DataOperate = new dataOperator();
        
        //form initialization
        public Form1()
        {
            InitializeComponent();
            listViewUpdate();
            modifyBtn.Visible = false;
            dateText.Text = DateTime.Now.ToString();
        }

        // delete button click event
        // deletes file according to first and last name of the record
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            data.firstName = fnameText.Text;
            data.lastName = lnameText.Text;
            if (DataOperate.doFileDelete(data))
            {
                MessageBox.Show("Deleted Successfully");
                listViewUpdate();
                emptyFields();
            }
            else
            {
                MessageBox.Show("Error in deletion!");
            }
        }

        //to clear the field data
        private void clearBtn_Click(object sender, EventArgs e)
        {
            emptyFields();
        }

        private void emptyFields()
        {
            fnameText.Text = "";
            minitText.Text = ""; 
            lnameText.Text = "";
            genderText.Text = "";
            phoneText.Text = "";
            emailText.Text = "";
            address1Text.Text = "" ;
            address2Text.Text = "";
            cityText.Text = "";
            stateText.Text = "";
            zipcodeText.Text = "";
            proofText.Text = "";
            dateText.Text = DateTime.Now.ToString();
            fnameText.ReadOnly = false;
            lnameText.ReadOnly = false;
            modifyBtn.Visible = false;
            addBtn.Visible = true;
        }
        private void fnameText_Enter(object sender,EventArgs e)
        {
            data.firstClick = DateTime.Now.TimeOfDay.ToString();
        }

        private void fnameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\b'){
                backSpace++;
            }
        }
        
        //modify btn click event
        //will validate for empty and valid conditions
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            data.firstName = fnameText.Text;
            data.middleInitial = minitText.Text;
            data.lastName = lnameText.Text;
            data.gender = genderText.Text.ToUpper();
            data.phone = phoneText.Text;
            data.email = emailText.Text;
            data.address1 = address1Text.Text;
            data.address2 = address2Text.Text;
            data.city = cityText.Text;
            data.state = stateText.Text;
            data.zipcode = zipcodeText.Text;
            data.purchase = proofText.Text.ToUpper();
            data.date = dateText.Text;
            string isEmpty = DataOperate.checkEmpty(data);
            string isValid = DataOperate.checkValid(data);
            if (isEmpty != "")
            {
                MessageBox.Show(isEmpty, "Error!");
            }
            else if (isValid != "")
            {
                MessageBox.Show(isValid, "Error!");
            }
            else
            {
                
                if (DataOperate.doFileModify(data))
                {
                    MessageBox.Show("Modified Successfully!");
                    listViewUpdate();
                    emptyFields();
                }
                else
                {
                    MessageBox.Show("Error in Modification");
                   
                }

            }
        }
        
        //add btn click event
        //will validate empty conditions and validations

        private void addBtn_Click(object sender, EventArgs e)
        {
            data.firstName = fnameText.Text;
            Console.WriteLine(data.firstName);
            data.middleInitial = minitText.Text;
            data.lastName = lnameText.Text;
            data.gender = genderText.Text.ToUpper();
            data.phone = phoneText.Text;
            data.email = emailText.Text;
            data.address1 = address1Text.Text;
            data.address2 = address2Text.Text;
            data.city = cityText.Text;
            data.state = stateText.Text;
            data.zipcode = zipcodeText.Text;
            data.purchase = proofText.Text.ToUpper();
            data.date = DateTime.Now.ToString();
            string isEmpty = DataOperate.checkEmpty(data);
            string isValid = DataOperate.checkValid(data);
            if(isEmpty != ""){
                Console.WriteLine("emptydata");
                MessageBox.Show(isEmpty);
            }else if(isValid != "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                data.addBtn = DateTime.Now.TimeOfDay.ToString();
                data.backSpace = backSpace;

                if (!DataOperate.doFileSave(data))
                {
                    
                    MessageBox.Show("User Exists!");
                }else
                {
                    MessageBox.Show("Successful insertion");
                    listViewUpdate();
                    emptyFields();
                }
              
            }

        }

        //updates the list view after add and delete operation
        void listViewUpdate()
        {
            Console.WriteLine("listview update is called");
            List<listSavedData> listedData = DataOperate.doUpdateList();
            Console.WriteLine("listedData" + listedData);
            listView.Items.Clear();
            
            foreach (listSavedData value in listedData)
            {
                
                ListViewItem item = new ListViewItem(new[] { value.entireName, value.phoneNumber });
                listView.Items.Add(item);
            }
            listView.View = View.Details;
            this.listView.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //to populate the data as per the item double click
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView.SelectedItems[0];
            GetterSetterClass popData = DataOperate.doDataPopulate(item.SubItems[0].Text);
            fnameText.Text = popData.firstName;
            minitText.Text = popData.middleInitial;
            lnameText.Text = popData.lastName;
            fnameText.ReadOnly = true;
            lnameText.ReadOnly = true;
            genderText.Text = popData.gender;
            phoneText.Text = popData.phone;
            emailText.Text = popData.email;
            address1Text.Text = popData.address1;
            address2Text.Text = popData.address2;
            cityText.Text = popData.city;
            stateText.Text = popData.state;
            zipcodeText.Text = popData.zipcode;
            proofText.Text = popData.purchase;
            dateText.Text = popData.date;
            addBtn.Visible = false;
            modifyBtn.Visible = true;
        }

        //down are the list of keypress events to calculate total backSpaces 
        private void minitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void lnameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void genderText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void emailText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void address1Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void address2Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void cityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void stateText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void zipcodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void proofText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }

        private void dateText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                backSpace++;
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
