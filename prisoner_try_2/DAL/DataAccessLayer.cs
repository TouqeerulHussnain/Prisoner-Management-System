using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prisoner_try_2
{
    class DataAccessLayer : MainConnection
    {
        public static int loginSecure = 0;
        public static int MasterLogin = 0;
        //8888888888888888888888888888888888888888888888888888888888888888888888888888
        //----------------------------Start---PRISONER--------------------------------
        //8888888888888888888888888888888888888888888888888888888888888888888888888888
        #region Prisoner

       

        public static DataSet GetThroughtDataAdapter()//-----------Disconnected laye through dataset
        {
            string qry = "select * from Prisoner_T;";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataSet db = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(db, "Tb_data");
            return db;
        }

        public static void Update(int prisonerId, string prisonerName, int prisonerAge, string pCrime, string pPunishment, string CrimeDate, string pReleaseDate)
        {
            
            //string qry = "update ABC2 set regNo = @updateReg, name = @Updatename,  number = @updatenumber where name =@serach";
            string qry = "update Prisoner_T set prisonerId=@prisonerId, prisonerName=@prisonerName, prisonerAge=@prisonerAge, pCrime=@pCrime, pPunishment=@pPunishment, CrimeDate=@CrimeDate, pReleaseDate=@pReleaseDate  where prisonerId = @Update";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@update", prisonerId);
            cmd.Parameters.AddWithValue("@prisonerId", prisonerId);
            cmd.Parameters.AddWithValue("@prisonerName", prisonerName);
            cmd.Parameters.AddWithValue("@prisonerAge", prisonerAge);
            cmd.Parameters.AddWithValue("@pCrime", pCrime);
            cmd.Parameters.AddWithValue("@pPunishment", pPunishment);
            cmd.Parameters.AddWithValue("@CrimeDate", CrimeDate);
            cmd.Parameters.AddWithValue("@pReleaseDate", pReleaseDate);
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
        public static DataSet SearchReg(int id)         //search for prisoner
        {
            string qry = "select * from Prisoner_T where prisonerId like @id";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data, "Search_Pdata");
            return data;

        }

        public static SqlDataReader getIds()//------------connected layer with datareader
                                                        // get items in combo box
        {
            string qry = "select prisonerId from Prisoner_T";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getSelectedIds(int pid)//------------connected layer with datareader
        {                                                                   // use to fill other items except combo box 
            string qry = "select * from Prisoner_T where prisonerId = @pid";
            SqlConnection connection = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@pid", pid);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static void AddRecord(int prisonerId, string prisonerName, int prisonerAge, string pCrime, string pPunishment, string CrimeDate, string pReleaseDate)
        {
            string qry = "insert into Prisoner_T values(@prisonerId,@prisonerName,@prisonerAge,@pCrime,@pPunishment,@CrimeDate,@pReleaseDate)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@prisonerId", prisonerId);
            cmd.Parameters.AddWithValue("@prisonerName", prisonerName);
            cmd.Parameters.AddWithValue("@prisonerAge", prisonerAge);
            cmd.Parameters.AddWithValue("@pCrime", pCrime);
            cmd.Parameters.AddWithValue("@pPunishment", pPunishment);
            cmd.Parameters.AddWithValue("@CrimeDate", CrimeDate);
            cmd.Parameters.AddWithValue("@pReleaseDate", pReleaseDate);
            cmd.ExecuteNonQuery();

        }



        public static DataSet getForRelaese(string start, string end)//------------connected layer with datareader
        {                                                                   // use to fill other items except combo box 
            string qry = "select * from Prisoner_T where CrimeDate >= @start and pReleaseDate <= @end;";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data, "Tb_data");
            return data;

        }

        public static DataSet RelaeseToday(string end)//------------connected layer with datareader
        {                                                                   // use to fill other items except combo box 
            string qry = "select * from Prisoner_T where pReleaseDate >= @end;";
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@end", end);
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(data, "Tb_data");
            return data;

        }
        #endregion
        //8888888888888888888888888888888888888888888888888888888888888888888888888888
        //----------------------------END---PRISONER----------------------------------
        //8888888888888888888888888888888888888888888888888888888888888888888888888888


    }
}
