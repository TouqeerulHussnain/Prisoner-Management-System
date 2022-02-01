using prisoner_try_2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Gaurd
{
    public partial class view_searchGaurd : Form
    {
        public view_searchGaurd()
        {
            InitializeComponent();
        }

        private void view_searchGaurd_Load(object sender, EventArgs e)
        {

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            DataSet db = GuardDataAccess.GetThroughtDataAdapter();
            grdGuard.DataSource = db.Tables["Tb_data"];
        }

        private void btnsrchgaurd_Click(object sender, EventArgs e)
        {
            int data = int.Parse(txtsearch.Text);
            DataSet db = GuardDataAccess.SearchReg(data);
            grdGuard.DataSource = db.Tables["Search_pdata"];
        }
    }
}
