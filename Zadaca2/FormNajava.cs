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

namespace Zadaca2
{
    public partial class FormNajava : Form
    {
        public FormNajava()
        {
            InitializeComponent();
        }

        private void btnNajaviSe_Click(object sender, EventArgs e)
        {
            
            string conString;
            SqlCommand cmd;
            SqlConnection con;
            SqlDataReader dataReader;
            string sql;


            conString = Program.connectionString;
            con = new SqlConnection(conString);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Проблем со поврзување со базата!");
                return;
            }
            try
            {
                sql = "Select ID, UserName, Pass from [Config Schema].Operators";

                cmd = new SqlCommand(sql, con);
                dataReader = cmd.ExecuteReader();


                // Citanje od baza 

                string pass, nickname;
                int id = 0;
                try
                {
                    bool loggedIn = false;
                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader.GetValue(0).ToString());
                        nickname = dataReader.GetValue(1).ToString();
                        pass = dataReader.GetValue(2).ToString();

                        if (nickname == tbNickNameNajava.Text && pass == tbPasswordNajava.Text)
                        {
                            this.Hide();
                            loggedIn = true;
                            break;
                        }

                    }
                    dataReader.Close();
                    if (loggedIn == false)
                    {
                        MessageBox.Show("Операторот не постои.Обидете се повторно!");
                    }
                    else
                    {
                        sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Data Schema].OperatorsLogin')";

                        cmd = new SqlCommand(sql, con);


                        cmd.CommandText = @"INSERT INTO [Data Schema].OperatorsLogin (OperatorID,Timestamp) VALUES (@IDkorisnik, @timestamp)";


                        cmd.Parameters.AddWithValue("@IDkorisnik", id);
                        cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        this.Hide();
                        try
                        {
                            FormFunctions formFunctions = new FormFunctions(tbNickNameNajava.Text);
                            formFunctions.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Има проблем со внесување на податоците во база!");
                }
            }
            catch
            {
                MessageBox.Show("Дата базата која моментално ја користите е нефункционална.Изберете друга.");
                FormFunctions ff = new FormFunctions();
                ff.ShowDialog();
            }
            tbNickNameNajava.Text = "";
            tbPasswordNajava.Text = "";
            con.Close();
        }

        private void FormNajava_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
            Close();
        }
        
    }
}
