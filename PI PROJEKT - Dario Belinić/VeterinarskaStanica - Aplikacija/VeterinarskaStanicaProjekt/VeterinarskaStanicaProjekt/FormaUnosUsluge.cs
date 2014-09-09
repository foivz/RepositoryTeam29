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
    public partial class FormaUnosUsluge : Form
    {
        public FormaUnosUsluge()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();

            string naziv_usluge = textBoxNazivUsluge.Text.ToString();
            string cijena_usluge = textBoxCijenaUsluge.Text.ToString();

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "insert into usluge('naziv_usluge','cijena_usluge','aktivna') values ('"+textBoxNazivUsluge.Text.ToString()+"','"+textBoxCijenaUsluge.Text.ToString()+"',1)";
            sql_cmd.ExecuteNonQuery();
            this.Close();
            MessageBox.Show("Uspješno ste dodali novu uslugu");
            sql_con.Close();
        }
    }
}
