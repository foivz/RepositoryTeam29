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
    public partial class FormaPregledUsluga : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd2;

        public FormaPregledUsluga()
        {
            InitializeComponent();
        }

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }

      

        private void FormaPregledUsluga_Load(object sender, EventArgs e)
        {
            Konektiranje();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select id_usluge,naziv_usluge,cijena_usluge from usluge where aktivna==1";
            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql_cmd);
            DataSet ds2 = new DataSet();
            try
            {
                da2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                dataGridViewUsluge.DataSource = dt2;
                dataGridViewUsluge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridViewUsluge.CurrentRow.Cells[0].Value.ToString();
            int id_usluge = Convert.ToInt32(vrijednost);

            Konektiranje();
            sql_con.Open();
            sql_cmd2 = sql_con.CreateCommand();
            sql_cmd2.CommandText = "update usluge set aktivna=2 where id_usluge = "+id_usluge;
            sql_cmd2.ExecuteNonQuery();

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select id_usluge,naziv_usluge,cijena_usluge from usluge where aktivna==1";
            sql_cmd.ExecuteNonQuery();
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql_cmd);
            DataSet ds2 = new DataSet();
            try
            {
                da2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                dataGridViewUsluge.DataSource = dt2;
                dataGridViewUsluge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Uspješno ste obrisali uslugu");
        
            sql_con.Close();
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridViewUsluge.CurrentRow.Cells[0].Value.ToString();
            int id_usluge = Convert.ToInt32(vrijednost);

            FormaUrediUslugu noviUrediUslugu = new FormaUrediUslugu(id_usluge);
            noviUrediUslugu.Show();

        }
    }
}
