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

namespace prisoner_try_2.PAL.Prisoner
{

    public partial class addPrisoner : Form
    {

        int check = 0;   // checking for existing prisoner id.
        int prisnerID;      // checking for existing prisoner id.
        int prisnerID2; // checking for existing prisoner id.
        int lastID;  // put next id while adding new record.

        public addPrisoner()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void addPrisoner_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DataAccessLayer.getIds();
            
            while (reader.Read())
            {
                lastID = int.Parse(reader["prisonerId"].ToString());
               
            }
            lastID = lastID + 1;
            txtID.Text = lastID.ToString() ;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnaddRecord_Click(object sender, EventArgs e)
        {

            prisnerID = int.Parse(txtID.Text);
            SqlDataReader reader = DataAccessLayer.getIds();
            while (reader.Read())
            {
                prisnerID2 = int.Parse(reader["prisonerId"].ToString());
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
                string crime = txtCrime.Text;
                string punishment = txtPunishment.Text;
                string dateCrime = dtpCrime.Text;
                string dateRelease = dtpRelease.Text;
                try
                {
                    DataAccessLayer.AddRecord(id, name, age, crime, punishment, dateCrime, dateRelease);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
