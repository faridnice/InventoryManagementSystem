using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class CustomerModuleForm : Form
    {
        //Database connection
        /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\binanuarfari\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");*///databse1
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\OneDrive\Documents\dbMS2.mdf;Integrated Security=True;Connect Timeout=30");//database2
        SqlCommand cm = new SqlCommand();

        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to save this customer?", "Saving customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname, cphone)VALUES(@cname. @cphone)",con);
                    cm.Parameters.AddWithValue("@cname",txtCusName.Text);
                    cm.Parameters.AddWithValue("@cphone", txtCusPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer already added!");
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtCusName.Clear();
            txtCusPhone.Clear();
            btnSaveCustomer.Enabled = true;
            btnUpdateCustomer.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
