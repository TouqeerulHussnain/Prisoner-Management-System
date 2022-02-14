using prisoner_try_2.PAL.Jailer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Home
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        int AdminID = 1234;
        string AdminPass = "abcd";
        int id;
        string passwordEntered;
        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            
            passwordEntered = txtPassword.Text;
            id = int.Parse(txtName.Text);
            #region With Adapter login

            
                
                if (id == AdminID)
                {
                    if (AdminPass == passwordEntered)
                    {
                        this.Hide();
                        DataAccessLayer.loginSecure = 1;

                        prisoner_try_2.Home h = new prisoner_try_2.Home();
                        h.Show();




                    }
                    else
                    {
                        MessageBox.Show("Invalid Inputs");
                    }
                
                
            #endregion
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            prisoner_try_2.Home h = new prisoner_try_2.Home();
            h.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
    }
}
