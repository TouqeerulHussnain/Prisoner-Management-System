using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Jailer
{
    public partial class J_View_Search : Form
    {
        public J_View_Search()
        {
            InitializeComponent();
        }

        private void J_View_Search_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataSet db = JailerDataAccess.GetThroughtDataAdapter();
            dataGridView.DataSource = db.Tables["Tb_data"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int data = int.Parse(txtboxSearch.Text);
            DataSet db = JailerDataAccess.SearchReg(data);
            dataGridView.DataSource = db.Tables["Search_pdata"];
        }
    }
}
