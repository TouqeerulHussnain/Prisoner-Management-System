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
        string password = "abcd";
        int Master_ID = 7420;
        string Master_Password = "7420";
        int id;
        string passwordEntered;
        private void btnAddJailer_Click(object sender, EventArgs e)
        {

            passwordEntered = txtPassword.Text;
            id = int.Parse(txtName.Text);
            #region With Adapter login
            if (DataAccessLayer.MasterLogin == 0)
            {

                
                if (id == AdminID)
                {
                    if (AdminPass == passwordEntered)
                    {
                        MessageBox.Show("Logined");
                        this.Hide();
                        DataAccessLayer.loginSecure = 1;

                        prisoner_try_2.Home h = new prisoner_try_2.Home();
                        h.Show();




                    }
                    else
                    {
                        MessageBox.Show("Invalid Inputs");
                    }
                }
                else
                {
                    if (id == Master_ID && passwordEntered == Master_Password)
                    {
                        MessageBox.Show("Logined");
                        this.Hide();
                        DataAccessLayer.loginSecure = 1;


                    }

                }
            #endregion
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
