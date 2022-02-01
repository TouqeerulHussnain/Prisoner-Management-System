using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.DAL
{
    class GuardDataAccess: MainConnection
    {

        /*
         
                        // Sql Server Table
         * 
          GuardTable (	guardID int,
							guardName varchar(30),
							guardAddress varchar(50),
							guardPhone bigint,
							guardTime int,
							guardShift varchar(20)
							
							);
         
         
         */
        public static DataSet GetThroughtDataAdapter()//-----------Disconnected laye through dataset
        {
            string qry = "select * from GuardTable;";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataSet db = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(db, "Tb_data");
            return db;
        }


        public static DataSet SearchReg(int id)         //search for prisoner
        {
            string qry = "select * from GuardTable where guardID like @id";
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
            string qry = "select guardID from GuardTable";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetPrisonerSelectedIds(int guardID)//------------connected layer with datareader
        {                                                                   // use to fill other items except combo box 
            string qry = "select * from GuardTable where guardID = @guardID";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@guardID", guardID);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static void AddRecordJailer(int guardID, string guardName, string guardAddress, long guardPhone, int guardTime, string guardShift)
        {
            string qry = "insert into GuardTable values(@guardID,@guardName,@guardAddress,@guardPhone,@guardTime,@guardShift)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@guardID", guardID);
            cmd.Parameters.AddWithValue("@guardName", guardName);
            cmd.Parameters.AddWithValue("@guardAddress", guardAddress);
            cmd.Parameters.AddWithValue("@guardPhone", guardPhone);
            cmd.Parameters.AddWithValue("@guardTime", guardTime);
            cmd.Parameters.AddWithValue("@guardShift", guardShift);
            cmd.ExecuteNonQuery();

        }

        public static void Update(int guardID, string guardName, string guardAddress, long guardPhone, int guardTime, string guardShift)
        {

            //string qry = "update ABC2 set regNo = @updateReg, name = @Updatename,  number = @updatenumber where name =@serach";
            string qry = "update GuardTable set guardID=@guardID, guardName=@guardName, guardAddress=@guardAddress, guardPhone=@guardPhone, guardTime=@guardTime, guardShift=@guardShift where guardID = @update ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@update", guardID);
            cmd.Parameters.AddWithValue("@guardID", guardID);
            cmd.Parameters.AddWithValue("@guardName", guardName);
            cmd.Parameters.AddWithValue("@guardAddress", guardAddress);
            cmd.Parameters.AddWithValue("@guardPhone", guardPhone);
            cmd.Parameters.AddWithValue("@guardTime", guardTime);
            cmd.Parameters.AddWithValue("@guardShift", guardShift);
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
            string qry = "delete GuardTable  where guardID =@guardID";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@guardID", jailerID);
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

    }
}
