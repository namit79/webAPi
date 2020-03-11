 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using start.Models;

namespace start.database_Access_Layer
{
    public class db
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public DataSet GetAllUsers()
        {

            MySqlCommand com = new MySqlCommand("GetAllUsers",con);
            com.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet GetUsersById(int id)
        {

            MySqlCommand com = new MySqlCommand("AddDocument", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("id",id);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet AddDocuments(document dc)
        {

            MySqlCommand com = new MySqlCommand("getUserById", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("document", dc.documentName);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}