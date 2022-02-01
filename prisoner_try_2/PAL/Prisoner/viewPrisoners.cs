using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Prisoner
{
    public partial class viewPrisoners : Form
    {
        public viewPrisoners()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnviewdata_Click(object sender, EventArgs e)
        {

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            DataSet db = DataAccessLayer.GetThroughtDataAdapter();
            grdPrisoner.DataSource = db.Tables["Tb_data"];

        }

        private void btnsrchgaurd_Click(object sender, EventArgs e)
        {
            int data = int.Parse(txtSearchID.Text);
            DataSet db = DataAccessLayer.SearchReg(data);
            grdPrisoner.DataSource = db.Tables["Search_pdata"];
        }
    }
}
