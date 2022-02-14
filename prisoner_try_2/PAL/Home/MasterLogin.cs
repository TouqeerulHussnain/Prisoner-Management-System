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
    public partial class MasterLogin : Form
    {
        public MasterLogin()
        {
            InitializeComponent();
        }
        string password;
        int Master_ID = 7240;
        string Master_Password = "7240";
        int id;
        string passwordEntered;
        private void btnAddJailer_Click(object sender, EventArgs e)
        {

            id = int.Parse(txtName.Text.ToString());
            passwordEntered = txtPassword.Text;
            
                if (id == Master_ID && passwordEntered == Master_Password)
                {
                    this.Hide();
                    DataAccessLayer.loginSecure = 1;
                    prisoner_try_2.Home h = new prisoner_try_2.Home();
                    h.Show();
                    DataAccessLayer.MasterLogin = 1;

                }
                else
                {
                    MessageBox.Show("Invalid Entry");
                }
            
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            prisoner_try_2.Home h = new prisoner_try_2.Home();
            h.Show();
        }
    }
}
