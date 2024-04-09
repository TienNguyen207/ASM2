using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace New_ASM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve input data from textboxes and dropdowns
            string no = tbno.Text;
            string name = tbName.Text;
            string lastmonth = tbLast.Text;
            string thismonth = tbThis.Text;
            string typer = cbType.Text;

            // Create a new list view item
            ListViewItem item = new ListViewItem();

            // Add customer data to the list view item
            item.Text = no;
            item.SubItems.Add(name);
            item.SubItems.Add(lastmonth);
            item.SubItems.Add(thismonth);
            item.SubItems.Add(typer);

            // Add the list view item to the list view
            listView1.Items.Add(item);

            // Calculate water bill based on consumption and customer type
            double This;
            double last;
            double.TryParse(lastmonth, out This);
            double.TryParse(thismonth, out last);

            double price = 0;
            double consumption = last - This;
            if (typer == "Household customer")
            {
                // Calculate price based on consumption for household customers
                if (consumption > 0 && consumption <= 10)
                {
                    price = consumption * 5.973;
                }
                else if (consumption > 10 && consumption <= 20)
                {
                    price = consumption * 7.052;
                }
                else if (consumption > 20 && consumption <= 30)
                {
                    price = consumption * 8.699;
                }
                else
                {
                    price = consumption * 15.929;
                }
            }
            else if (typer == "Administrative agency, public services")
            {
                // Calculate price based on consumption for administrative agencies/public services
                price = consumption * 9.955;
            }
            else if (typer == "Production units")
            {
                // Calculate price based on consumption for production units
                price = consumption * 11.615;
            }
            else if (typer == "Business services")
            {
                // Calculate price based on consumption for business services
                price = consumption * 22.068;
            }
            else
            {
                MessageBox.Show("Choose the right customer type.");
            }

            // Calculate VAT (Value Added Tax) and total bill
            double VAT = price * 0.1;
            double Total = VAT + price;
            item.SubItems.Add(VAT.ToString());
            item.SubItems.Add(Total.ToString());

        }

        // Event handler for the "Edit" button click
        private void btedit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Retrieve selected item from list view
                ListViewItem item = new ListViewItem(tbno.Text);
                item.Text = tbno.Text;
                item.SubItems.Add(tbName.Text);
                item.SubItems.Add(tbLast.Text);
                item.SubItems.Add(tbThis.Text);
                item.SubItems.Add(cbType.Text);
                listView1.Items.Add(item);

                // Remove selected item from list view
                listView1.Items.Remove(listView1.SelectedItems[0]);
                string lastmonth = tbLast.Text;
                string thismonth = tbThis.Text;
                string selectedText = cbType.Text;
                double This;
                double last;
                double.TryParse(lastmonth, out This);
                double.TryParse(thismonth, out last);

                // Calculate price based on consumption and customer type
                double price = 0;
                double consumption = last - This;
                if (selectedText == "Household customer")
                {
                    // Calculate price based on consumption for household customers
                    if (consumption > 0 && consumption <= 10)
                    {

                        price = consumption * 5.973;

                    }
                    else if (consumption > 10 && consumption <= 20)
                    {
                        price = consumption * 7.052;
                    }
                    else if (consumption > 20 && consumption <= 30)
                    {
                        price = consumption * 8.699;
                    }
                    else
                    {
                        price = consumption * 15.929;
                    }

                }
                else if (selectedText == "Administrative agency, public services")
                {
                    // Calculate price based on consumption for administrative agencies/public services
                    price = consumption * 9.955;
                }
                else if (selectedText == "Production units")
                {
                    // Calculate price based on consumption for production units
                    price = consumption * 11.615;
                }
                else if (selectedText == "Business services")
                {
                    // Calculate price based on consumption for business services
                    price = consumption * 22.068;
                }

                else
                {
                    MessageBox.Show("chosse right customer");
                }
                // Calculate VAT (Value Added Tax) and total bill
                double VAT = price * 0.1;
                double Total = VAT + price;
                item.SubItems.Add(VAT + "");
                item.SubItems.Add(Total + "");
            }
            btedit.Enabled = true;
            tbno.Text = null;
            tbName.Text = null;
            tbLast.Text = null;
            tbThis.Text = null;
            cbType.SelectedIndex = -1;
        }

        // Event handler for the "Delete" button click
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Prompt user to confirm deletion
                DialogResult delete = MessageBox.Show("Do you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    // Remove selected item from list view
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please choose data to delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the "Exit" button click
        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configure list view
            listView1.FullRowSelect = true;
            listView1.Columns.Add("No", 50);
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Last", 100);
            listView1.Columns.Add("This", 100);
            listView1.Columns.Add("TyperCustomer", 150);
            listView1.Columns.Add("VAT", 100);
            listView1.Columns.Add("Total", 100);
        }

        // Event handler for the list view item selection change
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Retrieve selected item from list view
                ListViewItem item = listView1.SelectedItems[0];
                tbno.Text = item.SubItems[0].Text;
                tbName.Text = item.SubItems[1].Text;
                tbLast.Text = item.SubItems[2].Text;
                tbThis.Text = item.SubItems[3].Text;
                cbType.Text = item.SubItems[4].Text;

                // Enable edit button
                btedit.Enabled = true;
            }

        }
    }
}
