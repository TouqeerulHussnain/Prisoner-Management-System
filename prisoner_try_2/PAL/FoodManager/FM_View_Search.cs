using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.FoodManager
{
    public partial class FM_View_Search : Form
    {
        public FM_View_Search()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataSet db = FoodMngDataAccess.GetThroughtDataAdapter();
            dataGridView.DataSource = db.Tables["Tb_data"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int data = int.Parse(txtboxSearch.Text);
            DataSet db = FoodMngDataAccess.SearchReg(data);
            dataGridView.DataSource = db.Tables["Search_pdata"];
        }
    }
}
