using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.Jailer
{
    class JailerDataAccess : MainConnection
    {
        public static int loginSecure = 0;
        public static int MasterLogin = 0;
        //8888888888888888888888888888888888888888888888888888888888888888888888888888
        //----------------------------Start---PRISONER--------------------------------
        //8888888888888888888888888888888888888888888888888888888888888888888888888888
        #region Prisoner

       

        public static DataSet GetThroughtDataAdapter()//-----------Disconnected laye through dataset
        {
            string qry = "select * from JailerTable;";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataSet db = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(db, "Tb_data");
            return db;
        }


        public static DataSet SearchReg(int id)         //search for prisoner
        {
            string qry = "select * from JailerTable where jailerID like @id";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data, "Search_Pdata");
            return data;

        }

        public static SqlDataReader GetJailerIds()//------------connected layer with datareader
        // get items in combo box
        {
            string qry = "select jailerID from JailerTable";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetSelectedIds(int pid)//------------connected layer with datareader
        {                                                                   // use to fill other items except combo box 
            string qry = "select * from JailerTable where jailerID = @pid";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@pid", pid);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static void AddRecordJailer(int jailerID, string jailerName, string jailerPass, string jailerEmail, string jailerAddress, int jailerAge, long jailerPhone)
        {
            string qry = "insert into JailerTable values(@jailerID,@jailerName,@jailerPass,@jailerEmail,@jailerAddress,@jailerAge,@jailerPhone)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@jailerID", jailerID);
            cmd.Parameters.AddWithValue("@jailerName", jailerName);
            cmd.Parameters.AddWithValue("@jailerPass", jailerPass);
            cmd.Parameters.AddWithValue("@jailerEmail", jailerEmail);
            cmd.Parameters.AddWithValue("@jailerAddress", jailerAddress);
            cmd.Parameters.AddWithValue("@jailerAge", jailerAge);
            cmd.Parameters.AddWithValue("@jailerPhone", jailerPhone);
            cmd.ExecuteNonQuery();

        }

        public static void Update(int jailerID, string jailerName, string jailerPass, string jailerEmail, string jailerAddress, int jailerAge, long jailerPhone)
        {

            //string qry = "update ABC2 set regNo = @updateReg, name = @Updatename,  number = @updatenumber where name =@serach";
            string qry = "update JailerTable set jailerID=@jailerID, jailerName=@jailerName, jailerPass=@jailerPass, jailerEmail=@jailerEmail, jailerAddress=@jailerAddress, jailerAge=@jailerAge, jailerPhone=@jailerPhone where jailerID = @update ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@update", jailerID);
            cmd.Parameters.AddWithValue("@jailerID", jailerID);
            cmd.Parameters.AddWithValue("@jailerName", jailerName);
            cmd.Parameters.AddWithValue("@jailerPass", jailerPass);
            cmd.Parameters.AddWithValue("@jailerEmail", jailerEmail);
            cmd.Parameters.AddWithValue("@jailerAddress", jailerAddress);
            cmd.Parameters.AddWithValue("@jailerAge", jailerAge);
            cmd.Parameters.AddWithValue("@jailerPhone", jailerPhone);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }
        public static void DeleteRecord(int jailerID)
        {
            string qry = "delete JailerTable  where jailerID =@jailerID";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@jailerID", jailerID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");


            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public static DataSet Get_E_ThroughtDataAdapter(int id)//-----------Disconnected laye through dataset
        {
            string qry = "select * from JailerTable where jailerID = @Id";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            DataSet db = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(db, "Tb_data");
            return db;
        }
        #endregion

    }
}
