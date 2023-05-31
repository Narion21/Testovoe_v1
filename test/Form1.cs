using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipTb.Text = "127.0.0.1";
            portTb.Text = "5432";
            usernameTb.Text = "postgres";
            passwordTb.Text = "123456";
            databaseTb.Text = "carsDB";

            tableCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCars.AllowUserToAddRows = false;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.server = ipTb.Text;
                dataBase.port = portTb.Text;
                dataBase.username = usernameTb.Text;
                dataBase.password = passwordTb.Text;
                dataBase.database = databaseTb.Text;
                dataBase.DataBaseOpen();
                dataBase.DataBaseClose();

                Console.WriteLine("Соединение с БД открыто");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
                
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataBase.DataBaseOpen();
            DataSet ds = dataBase.Show(dataBase.sqlCars);           
            dataBase.DataBaseClose();
            tableCars.DataSource = ds.Tables[0];

            dataBase.DataBaseOpen();
            DataSet ds1 = dataBase.Show(dataBase.sqlMarks);
            dataBase.DataBaseClose();
            tableMarks.DataSource = ds1.Tables[0];

            dataBase.DataBaseOpen();
            DataSet ds2 = dataBase.Show(dataBase.sqlOwners);
            dataBase.DataBaseClose();
            tableOwners.DataSource = ds2.Tables[0];

        }
    }
}
