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
    public partial class FM_Delete : Form
    {
        public FM_Delete()
        {
            InitializeComponent();
        }

        private void cmbJailerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prisnerID = int.Parse(cmbFood.SelectedItem.ToString());
            SqlDataReader reader = FoodMngDataAccess.GetSelectedIds(prisnerID);
            while (reader.Read())
            {

                txtName.Text = reader["MangName"].ToString();
                txtAddress.Text = reader["mangAddress"].ToString();
                txtExp.Text = reader["mangExp"].ToString();
                txtEmail.Text = reader["mangEmail"].ToString();
                txtPhone.Text = reader["mangPhone"].ToString();
                txtAge.Text = reader["mangAge"].ToString();
            }
        }

        private void FM_Delete_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = FoodMngDataAccess.GetIds();
            while (reader.Read())
            {
                cmbFood.Items.Add(reader["FoodMangID"].ToString());
            }
        }

        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbFood.Text);
            string name = txtName.Text;
            int exp = int.Parse(txtExp.Text);
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            long phone = long.Parse(txtPhone.Text);
            int age = int.Parse(txtAge.Text);
            FoodMngDataAccess.DeleteRecord(id);
        }
    }
}
