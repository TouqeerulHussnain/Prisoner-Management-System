
using prisoner_try_2.DAL;
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

namespace prisoner_try_2.PAL.Gaurd
{
    public partial class addGaurd : Form
    {


        int check = 0;   // checking for existing prisoner id.
        int prisnerID;      // checking for existing prisoner id.
        int prisnerID2; // checking for existing prisoner id.
        int lastID;  // put next id while adding new record.
        
        public addGaurd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaddRecord_Click(object sender, EventArgs e)
        {
            prisnerID = int.Parse(txtID.Text);
            SqlDataReader reader = GuardDataAccess.GetJailerIds();
            while (reader.Read())
            {
                prisnerID2 = int.Parse(reader["guardID"].ToString());
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

                string address = txtAddress.Text;
                long phone = long.Parse(txtPhone.Text);
                int time = int.Parse(txtTime.Text);
                string shift = txtShift.Text;
                try
                {
                    GuardDataAccess.AddRecordJailer(id, name, address, phone, time,shift);

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

        private void addGaurd_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = GuardDataAccess.GetJailerIds();

            while (reader.Read())
            {
                lastID = int.Parse(reader["guardID"].ToString());

            }
            lastID = lastID + 1;
            txtID.Text = lastID.ToString();
        }
    }
}
