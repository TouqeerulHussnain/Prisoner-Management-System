using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prisoner_try_2.PAL;
using prisoner_try_2.PAL.Jailer;
namespace prisoner_try_2.PAL.controler
{
    public partial class UC_jailer : UserControl
    {
        public UC_jailer()
        {
            InitializeComponent();
        }

        private void UC_jailer_Load(object sender, EventArgs e)
        {

        }

        private void btnFM_Add_Click(object sender, EventArgs e)
        {
            J_Add jAdd = new J_Add();
            jAdd.TopLevel = false;
            pnlExternalMerge.Controls.Clear();
            pnlExternalMerge.Controls.Add(jAdd);
            jAdd.Show();
        }

        private void btnFM_View_Click(object sender, EventArgs e)
        {
            J_View_Search jAdd = new J_View_Search();
            jAdd.TopLevel = false;
            pnlExternalMerge.Controls.Clear();
            pnlExternalMerge.Controls.Add(jAdd);
            jAdd.Show();
        }

        private void btnFM_Del_Click(object sender, EventArgs e)
        {
            J_Delete jAdd = new J_Delete();
            jAdd.TopLevel = false;
            pnlExternalMerge.Controls.Clear();
            pnlExternalMerge.Controls.Add(jAdd);
            jAdd.Show();
        }

        private void btnFM_Update_Click(object sender, EventArgs e)
        {
            J_Update jAdd = new J_Update();
            jAdd.TopLevel = false;
            pnlExternalMerge.Controls.Clear();
            pnlExternalMerge.Controls.Add(jAdd);
            jAdd.Show();
        }

        private void panalFoodmanager_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
