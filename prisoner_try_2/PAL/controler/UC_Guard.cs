using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prisoner_try_2.PAL.Gaurd;
namespace prisoner_try_2.PAL.controler
{
    public partial class UC_Guard : UserControl
    {
        public UC_Guard()
        {
            InitializeComponent();
        }

        private void UC_Guard_Load(object sender, EventArgs e)
        {

        }

        private void btnaddGaurd_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            addGaurd fadd = new addGaurd();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }

        private void btnviewsrchGaurd_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            view_searchGaurd fadd = new view_searchGaurd();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }

        private void btndltGaurd_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();
            deleteGaurd fadd = new deleteGaurd();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }

        private void btnupdateGaurd_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();
            updateGaurd fadd = new updateGaurd();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }
    }
}
