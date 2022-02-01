using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisoner_try_2.PAL.FoodManager
{
    class FoodMngDataAccess: MainConnection
    {



        /*
         *      // Sql Server Table
         
         create table FoodManganerTable( FoodMangID int primary key,
						MangName varchar(20),
						mangExp int,
						mangEmail varchar(30),
						mangAddress varchar(30),
						mangAge int,
						mangPhone bigint);
         
         
         */
        public static DataSet GetThroughtDataAdapter()//-----------Disconnected laye through dataset
        {
            string qry = "select * from FoodManganerTable;";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataSet db = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(db, "Tb_data");
            return db;
        }


        public static DataSet SearchReg(int id)         //search for prisoner
        {
            string qry = "select * from FoodManganerTable where FoodMangID like @id";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data, "Search_Pdata");
            return data;

        }

        public static SqlDataReader GetIds()//------------connected layer with datareader
        // get items in combo box
        {
            string qry = "select FoodMangID from FoodManganerTable";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetSelectedIds(int FoodMangID)//------------connected layer with datareader
        {                                                                   // use to fill other items except combo box 
            string qry = "select * from FoodManganerTable where FoodMangID = @FoodMangID";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@FoodMangID", FoodMangID);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static void AddRecord(int FoodMangID, string MangName, int mangExp, string mangEmail, string mangAddress, int mangAge, long mangPhone)
        {
            string qry = "insert into FoodManganerTable values(@FoodMangID,@MangName,@mangExp,@mangEmail,@mangAddress,@mangAge,@mangPhone)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@FoodMangID", FoodMangID);
            cmd.Parameters.AddWithValue("@MangName", MangName);
            cmd.Parameters.AddWithValue("@mangExp", mangExp);
            cmd.Parameters.AddWithValue("@mangEmail", mangEmail);
            cmd.Parameters.AddWithValue("@mangAddress", mangAddress);
            cmd.Parameters.AddWithValue("@mangAge", mangAge);
            cmd.Parameters.AddWithValue("@mangPhone", mangPhone);
            cmd.ExecuteNonQuery();

        }

        public static void Update(int FoodMangID, string MangName, int mangExp, string mangEmail, string mangAddress, int mangAge, long mangPhone)
        {

            //string qry = "update ABC2 set regNo = @updateReg, name = @Updatename,  number = @updatenumber where name =@serach";
            string qry = "update FoodManganerTable set FoodMangID=@FoodMangID, MangName=@MangName, mangExp=@mangExp, mangEmail=@mangEmail, mangAddress=@mangAddress, mangAge=@mangAge, mangPhone=@mangPhone where FoodMangID = @update ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@update", FoodMangID);
            cmd.Parameters.AddWithValue("@FoodMangID", FoodMangID);
            cmd.Parameters.AddWithValue("@MangName", MangName);
            cmd.Parameters.AddWithValue("@mangExp", mangExp);
            cmd.Parameters.AddWithValue("@mangEmail", mangEmail);
            cmd.Parameters.AddWithValue("@mangAddress", mangAddress);
            cmd.Parameters.AddWithValue("@mangAge", mangAge);
            cmd.Parameters.AddWithValue("@mangPhone", mangPhone);
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
        public static void DeleteRecord(int FoodMangID)
        {
            string qry = "delete FoodManganerTable  where FoodMangID =@FoodMangID";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@FoodMangID", FoodMangID);
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
