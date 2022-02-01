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
    public partial class J_Update : Form
    {
        public J_Update()
        {
            InitializeComponent();
        }

        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbJailer.Text);
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string pass = txtPassword.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            long phone = long.Parse(txtPhone.Text);
            JailerDataAccess.Update(id, name, pass, email, address, age, phone);
            
        }

        private void J_Update_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = JailerDataAccess.GetJailerIds();
            while (reader.Read())
            {
                cmbJailer.Items.Add(reader["jailerID"].ToString());
            }
        }

        private void cmbJailerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int prisnerID = int.Parse(cmbJailer.SelectedItem.ToString());
            SqlDataReader reader = JailerDataAccess.GetSelectedIds(prisnerID);
            while (reader.Read())
            {

                txtName.Text = reader["jailerName"].ToString();
                txtPassword.Text = reader["jailerPass"].ToString();
                txtEmail.Text = reader["jailerEmail"].ToString();
                txtAddress.Text = reader["jailerAddress"].ToString();
                txtAge.Text = reader["jailerAge"].ToString();
                txtPhone.Text = reader["jailerPhone"].ToString();

            }
        }
    }
}
