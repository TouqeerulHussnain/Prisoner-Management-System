using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prisoner_try_2;
using prisoner_try_2.DAL;
using prisoner_try_2.PAL;
using System.Data.SqlClient;
using System.Data.Sql;
namespace prisoner_try_2.PAL.Jailer
{
    public partial class J_Login : Form
    {
        public J_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        string password;
        int id;
        string passwordEntered;
        int CheckID;
        int cmboID;
        private void btnAddJailer_Click(object sender, EventArgs e)
        {

            id = int.Parse(cmbLoginId.Text);
            passwordEntered = txtPassword.Text;
            //id = int.Parse(txtName.Text);
            #region With Adapter login

            SqlDataReader reader = JailerDataAccess.GetJailerIds();
            while (reader.Read())
            {
                

            }
            
            DataSet dt = JailerDataAccess.Get_E_ThroughtDataAdapter(id);
            DataRow row = dt.Tables[0].Rows[0];
            password = row.ItemArray.GetValue(2).ToString();
            if (password == passwordEntered)
            {
                this.Hide();
                JailerDataAccess.loginSecure = 1;

                prisoner_try_2.Home h = new prisoner_try_2.Home();
                h.Show();




            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }

            
            
            #endregion
        }

        private void J_Login_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = JailerDataAccess.GetJailerIds();
            while (reader.Read())
            {

                cmbLoginId.Items.Add(reader["jailerID"].ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            prisoner_try_2.Home h = new prisoner_try_2.Home();
            h.Show();
        }
    }
}