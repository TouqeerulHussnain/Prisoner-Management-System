using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prisoner_try_2.PAL.Jailer;
using prisoner_try_2.PAL.FoodManager;
using prisoner_try_2.PAL.controler;
using prisoner_try_2.PAL.Home;
using prisoner_try_2;
using System.Data.SqlClient;
using System.Data.Sql;

namespace prisoner_try_2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Home_Load(object sender, EventArgs e)
        {
            SqlConnection con = DataAccessLayer.GetConnection();
            SlidePanel.Hide();
            btnPrisoner.Hide();
            btnGaurd.Hide();
            button4.Hide();
            btnFoodManagerMenu.Hide();
            btnJailerMenu.Hide();
            if (JailerDataAccess.loginSecure == 1)
            {
                SlidePanel.Show();
                button4.Show();
                btnGaurd.Show();
                btnPrisoner.Show();
                btnLoginAdmin.Hide();
                btnJailerLogin.Text = "   Logout";

                btnJailerLogin.ForeColor = Color.White;
                btnMasterLogin.Hide();
                lableMaster.Hide();
            
            }
            if (DataAccessLayer.loginSecure == 1)
            {
                SlidePanel.Show();
                button4.Show();
                btnGaurd.Show();
                btnPrisoner.Show();
                btnJailerMenu.Show();
                btnFoodManagerMenu.Show();
                btnJailerLogin.Hide();
                btnLoginAdmin.Text = "   Logout";

                btnLoginAdmin.ForeColor = Color.White;
                btnMasterLogin.Hide();
                lableMaster.Hide();

                
            }
            
            
            
            
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnJailerMenu.Height;
            SlidePanel.Top = btnJailerMenu.Top;
            UC_jailer uc = new UC_jailer();
            uc.Dock = DockStyle.Fill;
            panalContainPanals.Controls.Clear();
            panalContainPanals.Controls.Add(uc);
            uc.Show();
            uc.BringToFront();
        }

        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewSearch_Click(object sender, EventArgs e)
        {
            J_View_Search jview = new J_View_Search();
            jview.Show();
        }

        private void btnDelJailer_Click(object sender, EventArgs e)
        {
            J_Delete jdel = new J_Delete();
            jdel.Show();
        }

        private void BtnUpdateJailer_Click(object sender, EventArgs e)
        {
            J_Update jup = new J_Update();
            jup.Show();
        }

        private void btnFoodManager_Click(object sender, EventArgs e)
        {
            UC_FM uc = new UC_FM();
            uc.Dock = DockStyle.Fill;
            panalContainPanals.Controls.Clear();
            panalContainPanals.Controls.Add(uc);
            uc.Show();
            uc.BringToFront();
            SlidePanel.Height = btnFoodManagerMenu.Height;
            SlidePanel.Top = btnFoodManagerMenu.Top;
            
        }

        private void btnFM_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFM_View_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnFM_Del_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFM_Update_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panleJailer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panalFoodmanager_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnGaurd_Click(object sender, EventArgs e)
        {
            UC_Guard uc = new UC_Guard();
            uc.Dock = DockStyle.Fill;
            panalContainPanals.Controls.Clear();
            panalContainPanals.Controls.Add(uc);
            uc.Show();
            uc.BringToFront();
            SlidePanel.Height = btnGaurd.Height;
            SlidePanel.Top = btnGaurd.Top;
        }

        private void btnPrisoner_Click_1(object sender, EventArgs e)
        {

            UC_Prisoner uc_p = new UC_Prisoner();
            uc_p.Dock = DockStyle.Fill;
            panalContainPanals.Controls.Clear();
            panalContainPanals.Controls.Add(uc_p);
            uc_p.Show();
            uc_p.BringToFront();
            
            SlidePanel.Height = btnPrisoner.Height;
            SlidePanel.Top = btnPrisoner.Top;

        }

        private void admin_Menu2_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void admin_Menu1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panalContainPanals_Paint(object sender, PaintEventArgs e)
        {

        }
        DialogResult result;
        private void button3_Click_1(object sender, EventArgs e)
        {
            

            if (JailerDataAccess.loginSecure == 1)
            {
                result = MessageBox.Show("Want to log out", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    JailerDataAccess.loginSecure = 1;
                }
                else if (result == DialogResult.OK)
                {
                    JailerDataAccess.loginSecure = 0;
                }
                this.Hide();
                Home h = new Home();
                h.Show();
                //this.Show();
            }
            else
            {
                this.Hide();
                J_Login login = new J_Login();
                login.Show();
            }
            
            
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            
            
            

            if (DataAccessLayer.loginSecure == 1)
            {
                result = MessageBox.Show("Want to log out", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    DataAccessLayer.loginSecure = 1;
                }
                else if (result == DialogResult.OK)
                {
                    DataAccessLayer.loginSecure = 0;
                }
                this.Hide();
                Home h = new Home();
                h.Show();
                //this.Show();
            }
            else
            {
                this.Hide();
                AdminLogin login = new AdminLogin();
                login.Show();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Notification fm = new Notification();

            
            fm.Show();
            SlidePanel.Height = button4.Height;
            SlidePanel.Top = button4.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MasterLogin login = new MasterLogin();
            login.Show();
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutUS a = new AboutUS();
            a.Show();
        }
    }
}
