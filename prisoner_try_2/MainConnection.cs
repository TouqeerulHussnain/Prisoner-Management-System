using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2
{
    class MainConnection
    {
        public static SqlConnection GetConnection()
        {

            string str = "data source =DESKTOP-5TU2OCD ;initial catalog =PrisonerMngSys; integrated security = true;";
            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
                //MessageBox.Show("connected");  //checking the connection


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            return connection;
        }

    }
}
