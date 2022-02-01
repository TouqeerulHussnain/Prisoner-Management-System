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
        int Master_ID = 7420;
        string Master_Password = "7420";
        int id;
        string passwordEntered;
        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            
           
            passwordEntered = txtPassword.Text;
            id = int.Parse(txtName.Text);
            #region With Adapter login
            if (JailerDataAccess.MasterLogin == 0)
            {
                
                DataSet dt = JailerDataAccess.Get_E_ThroughtDataAdapter(id);
                DataRow row = dt.Tables[0].Rows[0];
                password = row.ItemArray.GetValue(2).ToString();
                if (password == passwordEntered)
                {
                    MessageBox.Show("Logined");
                    this.Hide();
                    JailerDataAccess.loginSecure = 1;

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
                    JailerDataAccess.loginSecure = 1;
                   
                    
                }

            }
            #endregion
        }

        private void J_Login_Load(object sender, EventArgs e)
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