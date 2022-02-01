using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prisoner_try_2.PAL.Prisoner;
namespace prisoner_try_2.PAL.controler
{
    public partial class UC_Prisoner : UserControl
    {
        public UC_Prisoner()
        {
            InitializeComponent();
        }

        private void UC_Prisoner_Load(object sender, EventArgs e)
        {

        }

        private void btnaddprisoner_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            addPrisoner fadd = new addPrisoner();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }

        private void btnupdPrisoner_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            updatePrisoner fadd = new updatePrisoner();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }

        private void btnsrchPrisoner_Click(object sender, EventArgs e)
        {
            //pnlExternalMerge.Controls.Clear();

            //searchPrisoner fadd = new searchPrisoner();
            //fadd.TopLevel = false;
            //pnlExternalMerge.Controls.Add(fadd);
            //fadd.Show();
        }

        private void btnviewPrisoner_Click(object sender, EventArgs e)
        {
            pnlExternalMerge.Controls.Clear();

            viewPrisoners fadd = new viewPrisoners();
            fadd.TopLevel = false;
            pnlExternalMerge.Controls.Add(fadd);
            fadd.Show();
        }
    }
}
