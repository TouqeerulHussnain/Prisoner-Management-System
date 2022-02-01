using prisoner_try_2.DAL;
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

namespace prisoner_try_2.PAL.Gaurd
{
    public partial class updateGaurd : Form
    {
        public updateGaurd()
        {
            InitializeComponent();
        }

        private void cmbJailerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int prisnerID = int.Parse(cmbGuard.SelectedItem.ToString());
            SqlDataReader reader = GuardDataAccess.GetPrisonerSelectedIds(prisnerID);
            while (reader.Read())
            {

                txtName.Text = reader["guardName"].ToString();
                txtAddress.Text = reader["guardAddress"].ToString();
                txtPhone.Text = reader["guardPhone"].ToString();
                txtTime.Text = reader["guardTime"].ToString();
               txtShift.Text = reader["guardShift"].ToString();

            }
        }

        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbGuard.Text);
            string name = txtName.Text;

            string address = txtAddress.Text;
            long phone = long.Parse(txtPhone.Text);
            int time = int.Parse(txtTime.Text);
            string shift = txtShift.Text;
            GuardDataAccess.Update(id, name, address, phone, time, shift);
        }

        private void updateGaurd_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = GuardDataAccess.GetJailerIds();
            while (reader.Read())
            {
                cmbGuard.Items.Add(reader["guardID"].ToString());
            }
        }
    }
}
