using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    internal class DataBase
    {
        public string sqlCars = "SELECT * FROM cars";
        public string sqlMarks = "SELECT * FROM marks";
        public string sqlOwners = "SELECT * FROM owners";
        NpgsqlConnection npgSqlConnection = null;
        public string server { set; get; }

        public string port { set; get; }

        public string username { set; get; }

        public string password { set; get; }

        public string database { set; get; }

        List<string> tableCarsList = new List<string>();
        List<string> tableMarksList = new List<string>();
        List<string> tableOwnersList = new List<string>();

        public static string tableNameCars = "cars";
        public static string tableNameMarks = "marks";
        public static string tableNameOwners = "owners";



        public DataBase()
        {
            tableCarsList.Add("car_id");
            tableCarsList.Add("serial");
            tableCarsList.Add("mark_id");
            tableCarsList.Add("owner_id");
            tableCarsList.Add("price");
            tableCarsList.Add("date_of_production");

            tableMarksList.Add("mark_id");
            tableMarksList.Add("mark_name");
            tableMarksList.Add("type");

            tableOwnersList.Add("owner_id");
            tableOwnersList.Add("first_name");
            tableOwnersList.Add("second_name");
            tableOwnersList.Add("mobile");
            tableOwnersList.Add("date_of_birth");

        }

        public void DataBaseOpen()
        {
            Console.WriteLine("OPEN DB");
            string connectionString = "Server=" + server + ";Port=" + port + ";Username=" + username + ";Password=" + password + ";Database=" + database;
            npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
        }

        public void DataBaseClose()
        {
            if (npgSqlConnection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("CLOSE DB");
                npgSqlConnection.Close();
            }
        }
        public DataSet Show(string value)
        {

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(value, npgSqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;

        }
        public void InsertToCars(List<string> textBoxList)
        {
            string command = "INSERT INTO " + tableNameCars + "(";
            for (int i = 0; i < 6; i++)
            {
                if (i <= 4)
                {
                    command += tableCarsList[i] + ',';
                }
                if (i == 5)
                {
                    command += tableCarsList[i];
                }
            }
            command = command + ")" + "VALUES" + "(";
            for (int j = 0; j < 6; j++)
            {
                if (j <= 4)
                {
                    command += "'" + textBoxList[j] + "'" + ',';
                }
                if (j == 5)
                {
                    command += "'" + textBoxList[j] + "'";
                }

            }
            command = command + ")";

            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void InsertToMarks(List<string> textBoxList)
        {
            string command = "INSERT INTO " + tableNameMarks + "(";
            for (int i = 0; i < 3; i++)
            {
                if (i <= 1)
                {
                    command += tableMarksList[i] + ',';
                }
                if (i == 2)
                {
                    command += tableMarksList[i];
                }
            }
            command = command + ")" + "VALUES" + "(";
            for (int j = 0; j < 3; j++)
            {
                if (j <= 1)
                {
                    command += "'" + textBoxList[j] + "'" + ',';
                }
                if (j == 2)
                {
                    command += "'" + textBoxList[j] + "'";
                }

            }
            command = command + ")";

            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void InsertToOwners(List<string> textBoxList)
        {
            string command = "INSERT INTO " + tableNameOwners + "(";
            for (int i = 0; i < 5; i++)
            {
                if (i <= 3)
                {
                    command += tableOwnersList[i] + ',';
                }
                if (i == 4)
                {
                    command += tableOwnersList[i];
                }
            }
            command = command + ")" + "VALUES" + "(";
            for (int j = 0; j < 5; j++)
            {
                if (j <= 3)
                {
                    command += "'" + textBoxList[j] + "'" + ',';
                }
                if (j == 4)
                {
                    command += "'" + textBoxList[j] + "'";
                }

            }
            command = command + ")";

            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateToMarks(List<string> textBoxList, string id)
        {
            string command = "UPDATE " + tableNameMarks + " SET ";
            for (int i = 0; i < textBoxList.Count; i++)
            {
                if (i < textBoxList.Count - 1)
                {
                    command += textBoxList[i] + ",";
                }
                else
                {
                    command += textBoxList[i];
                }

            }
            command = command + " WHERE id =" + id;

            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateToCars(List<string> textBoxList, string id)
        {
            string command = "UPDATE " + tableNameCars + " SET ";
            for (int i = 0; i < textBoxList.Count; i++)
            {
                if (i < textBoxList.Count - 1)
                {
                    command += textBoxList[i] + ",";
                }
                else
                {
                    command += textBoxList[i];
                }

            }
            command = command + " WHERE id =" + id;

            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateToOwners(List<string> textBoxList, string id)
        {
            string command = "UPDATE " + tableNameOwners + " SET ";
            for (int i = 0; i < textBoxList.Count; i++)
            {
                if (i < textBoxList.Count - 1)
                {
                    command += textBoxList[i] + ",";
                }
                else
                {
                    command += textBoxList[i];
                }

            }
            command = command + " WHERE id =" + id;

            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteFromCars(string id)
        {
            string command = "DELETE FROM " + tableNameCars + " WHERE id="+id;
            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteFromMarks(string id)
        {
            string command = "DELETE FROM " + tableNameMarks + " WHERE id=" + id;
            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteFromOwners(string id)
        {
            string command = "DELETE FROM " + tableNameOwners + " WHERE id=" + id;
            Console.WriteLine(command);
            NpgsqlCommand adapter = new NpgsqlCommand(command, npgSqlConnection);
            try
            {
                adapter.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

}
