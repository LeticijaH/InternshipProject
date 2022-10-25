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
    public partial class FormRegistracija : Form
    {
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void btRegistrirajSe_Click(object sender, EventArgs e)
        {
            try
            {
                string connString;
                SqlCommand cmd;
                SqlConnection con;
                SqlDataReader dataReader;
                string sql;

                if (String.IsNullOrEmpty(tbImeKorisnik.Text) || String.IsNullOrEmpty(tbPrezime.Text) || String.IsNullOrEmpty(tbNickNameR.Text) || String.IsNullOrEmpty(tbPasswordR.Text))
                {
                    MessageBox.Show("Проблем со регистрацијата! Обидете се повторно :)");
                    return;
                }

                string ime, prezime, korIme, lozinka;

                ime = tbImeKorisnik.Text;
                prezime = tbPrezime.Text;
                korIme = tbNickNameR.Text;


                if (tbPasswordR_Validating() == false)
                {
                    MessageBox.Show("Внесовте невалиден формат на лозинка!");
                    return;
                }

                lozinka = tbPasswordR.Text;


                // Povrzuvanje so baza

                connString = Program.connectionString;
                con = new SqlConnection(connString);
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Проблем со поврзување со базата!");
                    return;
                }
                // Citanje na podatocite od bazata,tabela : Operators
                try
                {
                    sql = "Select UserName FROM [Config Schema].Operators";

                    cmd = new SqlCommand(sql, con);
                    dataReader = cmd.ExecuteReader();

                    try
                    {
                        while (dataReader.Read())
                        {
                            string nickname;

                            nickname = dataReader.GetValue(0).ToString();

                            if (nickname == korIme)
                            {
                                dataReader.Close();
                                MessageBox.Show("Корисничкото име веќе постои!");
                            }
                        }
                        dataReader.Close();

                        con.Close();
                        // Vnesuvanje na podatocite vo bazata,tabela : Operators

                        Operator @operator = new Operator(ime, prezime, korIme, lozinka);
                        WriteDataOToSQL(@operator);

                        MessageBox.Show("Успешно се регистриравте во системот! За да продолжите понатаму најавете се!");
                        this.Hide();
                        FormStart start = new FormStart();
                        start.ShowDialog();

                    }
                    catch
                    {
                        MessageBox.Show("Има проблем со внесување на податоците во база!");
                    }

                }

                catch
                {
                    MessageBox.Show("Има проблем со конекцијата со базата!");
                }
            }
            catch
            {
                MessageBox.Show("Дата базата која моментално ја користите е нефункционална.Изберете друга.");
                FormFunctions ff = new FormFunctions();
                ff.ShowDialog();
            }

        }
        bool formatNotValid;
        public bool tbPasswordR_Validating()
        {
            string pass = tbPasswordR.Text;
            string specZnak = "@#$%^&*()~`+-_={}[]|\\/:;\"\'<>,.?";
            string broj = "123456789";
            bool contSpecSign = pass.Contains(specZnak.Substring(0, specZnak.Length));
            bool contNum = pass.Contains(broj.Substring(0, broj.Length));
            bool contUpper = false;

            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    contUpper = true;
                    break;
                }
                else
                    contUpper = false;
            }

            if (pass.Length < 8 || (contSpecSign == false && contNum == false && contUpper == false))
            {
                errorProviderLozinka.SetError(tbPasswordR, "Форматот на лозинката не е валиден!");
                formatNotValid = false;
            }
            else
            {
                errorProviderLozinka.SetError(tbPasswordR, "");
                formatNotValid = true;
            }
            return formatNotValid;
        }

        private void FormRegistracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
        }

        public void WriteDataOToSQL(Operator o)
        {
            string connString;
            SqlCommand cmd;
            SqlConnection con;
            string sql;


            connString = Program.connectionString;
            con = new SqlConnection(connString);
            try
            {
                con.Open();
            }
            catch
            {
                return;
            }

            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[Config Schema].Operators')";

            cmd = new SqlCommand(sql, con);


            cmd.CommandText = @"INSERT INTO [Config Schema].Operators (Name,LastName,UserName,Pass) VALUES (@ime, @prezime, @korIme, @lozinka)";

            cmd.Parameters.AddWithValue("@ime", o.Name);
            cmd.Parameters.AddWithValue("@prezime", o.LastName);
            cmd.Parameters.AddWithValue("@korIme", o.UserName);
            cmd.Parameters.AddWithValue("@lozinka", o.Password);
            cmd.ExecuteNonQuery();

            con.Close();

        }
    }
}
