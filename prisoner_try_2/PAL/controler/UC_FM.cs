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
using prisoner_try_2.PAL.Home;
using prisoner_try_2.PAL.FoodManager;
namespace prisoner_try_2.PAL.controler
{
    public partial class UC_FM : UserControl
    {
        public UC_FM()
        {
            InitializeComponent();
        }

        private void btnFM_Add_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            FM_Add fadd = new FM_Add();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }

        private void UC_FM_Load(object sender, EventArgs e)
        {

        }

        private void btnFM_View_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            FM_View_Search fvi = new FM_View_Search();
            fvi.TopLevel = false;
            pnlExternalMerge.Controls.Add(fvi);
            fvi.Show();
        }

        private void btnFM_Del_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();
            FM_Delete fdel = new FM_Delete();
            fdel.TopLevel = false;
            pnlExternalMerge.Controls.Add(fdel);
            fdel.Show();

        }

        private void btnFM_Update_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();
            FM_Update fup = new FM_Update();
            fup.TopLevel = false;
            pnlExternalMerge.Controls.Add(fup);
            fup.Show();
        }
    }
}
