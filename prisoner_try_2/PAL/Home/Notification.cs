using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Home
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            //select * from Prisoner_T where CrimeDate >= '2008-06-11' and pReleaseDate <= '2022-01-31';
        }

        private void dtpCrime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = dtpStart.Text;
            string end = dtpRelease.Text;
            DataSet db = DataAccessLayer.getForRelaese(start, end);
            gridNotice.DataSource = db.Tables["Tb_data"];


        }

        private void tnToday_Click(object sender, EventArgs e)
        {
            string end = DateTime.Now.Date.ToString("yyyy-MM-dd");
                
            DataSet db = DataAccessLayer.RelaeseToday(end);
            gridNotice.DataSource = db.Tables["Tb_data"];

        }
    }
}
