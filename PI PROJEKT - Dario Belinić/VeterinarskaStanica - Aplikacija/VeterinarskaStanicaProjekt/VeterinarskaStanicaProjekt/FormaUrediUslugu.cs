using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace VeterinarskaStanicaProjekt
{
    

    public partial class FormaUrediUslugu : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd2;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }

        public FormaUrediUslugu(int n)
        {
            InitializeComponent();
            
            int varijabla = n;
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select * from usluge where id_usluge = "+varijabla;
            sql_cmd.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd.ExecuteReader();

            string naziv_usluge = "";
            float cijena_usluge = 0;
            int sifra_usluge = 0;

            while (dr.Read())
            {
                naziv_usluge = dr.GetString(1);
                cijena_usluge = dr.GetFloat(2);
                sifra_usluge = dr.GetInt32(0);
            }
            labelhelp.Text = sifra_usluge.ToString();
            textBoxNazivUsluge.Text = naziv_usluge;
            textBoxCijenaUsluge.Text = cijena_usluge.ToString();
            sql_con.Close();
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            int sfrlju = Convert.ToInt32(labelhelp.Text);
            sql_cmd2 = sql_con.CreateCommand();
            sql_cmd2.CommandText = "update usluge set naziv_usluge='"+textBoxNazivUsluge.Text.ToString()+"',cijena_usluge='"+textBoxCijenaUsluge.Text.ToString()+"' where id_usluge="+sfrlju;
            sql_cmd2.ExecuteNonQuery();
            this.Close();
            MessageBox.Show("Uspješno ste izmjenili podatke o usluzi");
            sql_con.Close();
        }
    }
}
