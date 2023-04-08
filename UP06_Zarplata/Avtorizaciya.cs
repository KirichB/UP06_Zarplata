using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UP06_Zarplata
{
    public partial class Avtorizaciya : Form
    {
        public Avtorizaciya()
        {
            InitializeComponent();
        }

        private void Log_lab_Click(object sender, EventArgs e)
        {

        }

        private void Vhod_but_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;user id=user41_db;password=user41;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "Select * from [!31UP06_Avtorizaciya_zarplata] where Login='" + Log_text.Text + "' and Password='" + Pas_text.Text + "' and Id_Role = '2'";
            SqlConnection myConnection = new SqlConnection(connect);
            SqlCommand myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();
            SqlDataReader rd = myCommand.ExecuteReader();
            string Login = "null";
            string Password = "null";
            while (rd.Read())
            {
                Login = rd.GetString(1);
                Password = rd.GetString(2);
            }
            if (Password == "null" && Login == "null")

            {
                string connect2 = "data source=stud-mssql.sttec.yar.ru,38325;user id=user41_db;password=user41;MultipleActiveResultSets=True;App=EntityFramework";
                string command2 = "Select * from [!31UP06_Avtorizaciya_zarplata] where Login='" + Log_text.Text + "' and Password='" + Pas_text.Text + "' and Id_Role = '1'";
                SqlConnection myConnection2 = new SqlConnection(connect2);
                SqlCommand myCommand2 = new SqlCommand(command2, myConnection);
                SqlDataReader rd2 = myCommand2.ExecuteReader();
                string Login2 = "null";
                string Password2 = "null";
                while (rd2.Read())
                {
                    Login2 = rd2.GetString(1);
                    Password2 = rd2.GetString(2);
                }
                if (Password2 == "null" && Login2 == "null")
                {
                    MessageBox.Show("Вы ввели неверный логин или пароль");
                }
                else
                {
                    Admin form2 = new Admin();
                    form2.Show();
                    this.Hide();
                }
            }
            else
            {
                Sotrydnik form3 = new Sotrydnik();
                form3.Show();
                this.Hide();

            }
            myConnection.Close();
        }

        private void Avtorizaciya_Load(object sender, EventArgs e)
        {

        }
    }
}
