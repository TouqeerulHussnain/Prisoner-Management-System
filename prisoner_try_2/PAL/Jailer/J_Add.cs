using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Jailer
{
    public partial class J_Add : Form
    {
        int check = 0;   // checking for existing prisoner id.
        int prisnerID;      // checking for existing prisoner id.
        int prisnerID2; // checking for existing prisoner id.
        string lastID;  // put next id while adding new record.

        public J_Add()
        {
            InitializeComponent();
        }

        private void J_Add_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = JailerDataAccess.GetJailerIds();

            while (reader.Read())
            {
                lastID = reader["jailerID"].ToString();

            }
            lastID = lastID + 1;
            txtID.Text = lastID;
        }

        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            prisnerID = int.Parse(txtID.Text);
            SqlDataReader reader = JailerDataAccess.GetJailerIds();
            while (reader.Read())
            {
                prisnerID2 = int.Parse(reader["jailerID"].ToString());
                if (prisnerID2 == prisnerID)
                {

                    check = 1;
                    break;

                }


            }
            if (check == 0)
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                
                int age = int.Parse(txtAge.Text);
                string pass = txtPassword.Text;
                string email = txtEmail.Text;
                string adress = txtAddress.Text;
                long phone = long.Parse(txtPhone.Text);
                try
                {
                    JailerDataAccess.AddRecordJailer(id, name, pass, email, adress, age, phone);

                }
                catch (Exception)
                {

                    MessageBox.Show("Error");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("This Id Already Exit");
                check = 0;
            }

        }
    }
}
