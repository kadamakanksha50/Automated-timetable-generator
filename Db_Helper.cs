using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AutomatedTimeTable
{
    internal class Db_Helper
    {
        string connectionString = "server=localhost;user=root;password=;database=timetabledb";

        public int getSrNo(string query)
        {
            int srno = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                   // MessageBox.Show(query);
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                
                                while (reader.Read())
                                {
                                    //MessageBox.Show(reader[0].ToString());
                                    if (reader[0].ToString() == "")
                                    {
                                        srno = 0;
                                    } else
                                    {
                                        srno = Int32.Parse(reader[0].ToString());
                                    }
                                    
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error:"+ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            srno += 1;
            return srno;
        }
        public string getInfo(string query)
        {
            string data = "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    data = reader[0].ToString();

                                }
                            }
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }            
            return data;
        }
        public ArrayList getInfo1(string query)
        {
            ArrayList data = new ArrayList();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    data.Add(reader[0].ToString());
                                    
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return data;
        }
        public ArrayList getInfo11(string query)
        {
            ArrayList data = new ArrayList();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string result=(reader[0].ToString());
                                    result += "/" + reader[1].ToString();
                                    string temp = reader[2].ToString();
                                    
                                    string[] res = temp.Split("-");
                                    //MessageBox.Show(res.Length.ToString());
                                    if (res.Length > 2) 
                                    { 
                                        string t = res[0] + res[1];
                                        string r = res[2].Split("(")[0];
                                        result += "/" + t + "/" + r;
                                    }
                                    else
                                    {
                                        result += "/" + res[0] + "/" + res[1].Split("(")[0];
                                    }
                                    data.Add(result);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return data;
        }
        public Boolean validateLogin(String query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            return dataTable.Rows.Count > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }
        public void fillCombo(string query,ComboBox comboBox)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!comboBox.Items.Contains(reader[0].ToString()))
                                    {
                                        comboBox.Items.Add(reader[0].ToString());
                                    }
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public Boolean TableOperation(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {                        
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }                    
                }
                catch (MySqlException ex)
                {                   
                    MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return true;
        }
        public void showTimetable(String query, DataGridView dataGridView)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Day,First,Second,Third,Fourth,Fifth,Sixth,Seventh
                                    string? day = reader[0].ToString();
                                    string? first = reader[1].ToString();
                                    string? second = reader[2].ToString();
                                    string? third = reader[3].ToString();
                                    string? fourth = reader[4].ToString();
                                    string? fifth = reader[5].ToString();
                                    string? sixth = reader[6].ToString();
                                    string? seventh = reader[7].ToString();
                                    //MessageBox.Show(day+" "+first+" "+second+" "+third+" "+fourth+" "+fifth);
                                    dataGridView.Rows.Add(day, first, second, third, fourth, fifth, sixth, seventh);
                                }
                            }
                        }
                        dataGridView.ClearSelection();
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void show(String query,DataGridView dataGridView)
        {
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                            dataGridView.ClearSelection();
                            dataGridView.CurrentCell = null;
                        }
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void addSubjects(String query, DataGridView dataGridView)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string[] rowValues = new string[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowValues[i] = reader[i].ToString();
                            }
                            dataGridView.Rows.Add(rowValues);
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


    }
}
