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

namespace prisoner_try_2.PAL.Prisoner
{
    public partial class updatePrisoner : Form
    {
        public updatePrisoner()
        {
            InitializeComponent();
        }

        private void updatePrisoner_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DataAccessLayer.getIds();
            while (reader.Read())
            {
                cmbUpdate.Items.Add(reader["prisonerId"].ToString());
            }
        }

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prisnerID = int.Parse(cmbUpdate.SelectedItem.ToString());
            SqlDataReader reader = DataAccessLayer.getSelectedIds(prisnerID);
            while (reader.Read())
            {
                txtName.Text = reader["prisonerName"].ToString();
                txtAge.Text = reader["prisonerAge"].ToString();
                txtCrime.Text = reader["pCrime"].ToString();
                txtPunishment.Text = reader["pPunishment"].ToString();
                dtpCrime.Text = reader["CrimeDate"].ToString();
                dtpRelease.Text = reader["pReleaseDate"].ToString();

            }
        }

        private void btnAddJailer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbUpdate.Text);
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string crime = txtCrime.Text;
            string punishment = txtPunishment.Text;
            string dateCrime = dtpCrime.Text;
            string dateRelease = dtpRelease.Text;
            DataAccessLayer.Update(id, name, age, crime, punishment, dateCrime, dateRelease);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
