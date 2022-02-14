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

namespace prisoner_try_2.PAL.FoodManager
{
    public partial class FM_Add : Form
    {


        int check = 0;   // checking for existing prisoner id.
        int prisnerID;      // checking for existing prisoner id.
        int prisnerID2; // checking for existing prisoner id.
        int lastID;  // put next id while adding new record.

        public FM_Add()
        {
            InitializeComponent();
        }

        private void FM_Add_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = FoodMngDataAccess.GetIds();

            while (reader.Read())
            {
                lastID = int.Parse(reader["FoodMangID"].ToString());

            }
            lastID = lastID + 1;
            txtID.Text = lastID.ToString();

        }

        private void btnFM_Add_Click(object sender, EventArgs e)
        {
            prisnerID = int.Parse(txtID.Text);
            SqlDataReader reader = FoodMngDataAccess.GetIds();
            while (reader.Read())
            {
                prisnerID2 = int.Parse(reader["FoodMangID"].ToString());
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
                int exp = int.Parse(txtExp.Text);
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                long phone = long.Parse(txtPhone.Text);
                int age = int.Parse(txtAge.Text);
                try
                {
                    FoodMngDataAccess.AddRecord(id, name, exp, email, address,age, phone);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
