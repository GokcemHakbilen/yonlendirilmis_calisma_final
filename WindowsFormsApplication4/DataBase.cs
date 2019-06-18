using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    class DataBase
    {
        static string connectionString = "server=localhost;port=3306;database=project;uid=root;pwd=root;";
        MySqlConnection conn = new MySqlConnection(connectionString);
        string query;
        
        MySqlCommand myCommand;
        MySqlDataReader myReader;
        /*  public void connection()
          {
              string connectionString = "server=localhost;port=3306;database=project;uid=root;pwd=root;";
              MySqlConnection conn = new MySqlConnection(connectionString);
              string query;
              MySqlCommand myCommand;
              MySqlDataReader myReader;
          }*/
        public void Showtable(DataGridView tbl, string table)
        {
           
                try
                {
                    query = " select * from " + table + ";";
                    myCommand = new MySqlCommand(query, conn);
                    MySqlDataAdapter sda = new MySqlDataAdapter { SelectCommand = myCommand };
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource { DataSource = dbdataset };

                    tbl.DataSource = bSource;

                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

    

        public void Filtertable(DataGridView tbl, string table,string date1,string date2, string name, string target, string cpu, string tia, string cpuversion, string image)
        {
            string connectionString = "server=localhost;port=3306;database=project;uid=root;pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);
       
            try
            {
                string query;
                if (date2 != "") { 
                query = " select * from " + table + " where date between '" + date1 + "' and '" + date2 + "' and person like '%" + name + "%' and target like '%"
                    + target + "%' and cpu like '%" + cpu + "%' and tia like '%" + tia + "%' and cpuversion like '%" + cpuversion + "%' and image like '%" + image + "%';";
            }
                
                else query = " select * from " + table + " where date like '%" + date1 + "' and person like '%" + name + "%' and target like '%"
                    + target + "%' and cpu like '%" + cpu + "%' and tia like '%" + tia + "%' and cpuversion like '%" + cpuversion + "%' and image like '%" + image + "%';";
                var myCommand = new MySqlCommand(query, conn);
                myCommand = new MySqlCommand(query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = myCommand;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource { DataSource = dbdataset };
                tbl.DataSource = bSource;

                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insert_toDatabase(string table, string columns, string values)
        {
            try
            {
                query = "insert into " + table + " (" + columns + ") values(" + values + ");";
                myCommand = new MySqlCommand(query, conn);
             
                conn.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                MessageBox.Show(e.Message);
                return;
            }
        }
       
        public string selectoneitem(string table, string item, int id)
        {

            try
            {
                
                query = "select " +item+ " from " + table + " where id = " +id+ ";";
                string b = null;
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                
               

                while (myReader.Read())
                {
                    b = myReader[0].ToString();
                }
                return b;
                myReader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }

                MessageBox.Show(e.Message + "\n" + e.ToString());
                return "";
            }

        }

        public List<string> select_AllasArray(string table)
        {
            try
            {
                query = "select * from " + table + ";";
                
                List<string> list = new List<string>();
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetValue(0).ToString());
                }
                myReader.Close();
                conn.Close();
                return list;
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                List<string> list = new List<string>();
                list.Add(e.Message);
                MessageBox.Show(e.Message + "\n" + e.ToString());
                return list;
            }
        }
        public string select_asArray(string table,string item, string equal1, string equal2)
        {
            try
            {
                query = "select " +item+" from " + table + " where " + equal1 + " = " + equal2 + ";";
                string a = "";
                List<string> list = new List<string>();
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    a = Convert.ToString(myReader[0]);

                }
                myReader.Close();
                conn.Close();
                return a;
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                List<string> list = new List<string>();
                list.Add(e.Message);
                MessageBox.Show(e.Message + "\n" + e.ToString());

                return "";
            }
        }
        public List<string> Selectlike(string table,string column, string text)
        {
            try
            {
                query = "select " +column+ " from " + table + " where " +column+ " like '%" +text+ "%';";
            
                List<string> list = new List<string>();
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetValue(0).ToString());
                }
                myReader.Close();
                conn.Close();
                return list;
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                List<string> list = new List<string>();
                list.Add(e.Message);
                MessageBox.Show(e.Message + "\n" + e.ToString());
                return list;
            }
        }
        public List<string> SelectItem(string table, string item)
        {
            try
            {
              
                query = "select " + item + " from " + table + ";";  
                List<string> list = new List<string>();
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetValue(0).ToString());
                }

                myReader.Close();
                conn.Close();
                return list;
               

            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open")
                { conn.Close(); }
                List<string> list = new List<string>() { e.Message};
                MessageBox.Show(e.Message + "\n" + e.ToString());

                return list;
            }


        }
        public void delete_fromDatabase(string table, string column, string id)
        {
            try
            {
                query = "delete from " + table + " where " + column + " = '" + id + "' ;";
                myCommand = new MySqlCommand(query, conn);
             
                conn.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                MessageBox.Show(e.Message);
                return;
            }
        }
         public void update_ApplytoDatabase(string table, string column, string new_value, string Id)
        {
            try
            {
                query = "update " + table + " set " + column + " = '" + new_value + "' where Id = " + Id + ";";
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                MessageBox.Show(e.Message);
                return;
            }
        }

    }
}
