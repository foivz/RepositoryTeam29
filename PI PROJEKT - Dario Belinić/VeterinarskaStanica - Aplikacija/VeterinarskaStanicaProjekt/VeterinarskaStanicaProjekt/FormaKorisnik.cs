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
    public partial class FormaKorisnik : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteCommand sql_cmd1;
        private SQLiteCommand sql_cmd2;

        private void Konektiranje()
        {
            sql_con = new SQLiteConnection("Data Source=baza_veterinarska_stanica.sql;Version=3;New=False;Compress=True;");
        }
        public FormaKorisnik(int sB)
        {
            InitializeComponent();
            int idKorisnika = sB;
            
            Konektiranje();
            sql_con.Open();

            sql_cmd2 = sql_con.CreateCommand();
            sql_cmd2.CommandText = "select * from korisnici where id_korisnika =" + idKorisnika;
            sql_cmd2.ExecuteNonQuery();
            SQLiteDataReader dr2 = sql_cmd2.ExecuteReader();
            while (dr2.Read())
            {
                labelImeKorisnika.Text = dr2.GetString(5);
            }

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "select ljubimci.id_ljubimca,ljubimci.naziv,ljubimci.starost,tipovi_ljubimaca.naziv_tipa as tip,ljubimci.pasmina from ljubimci left join tipovi_ljubimaca on tipovi_ljubimaca.id_tipa_ljubimca = ljubimci.tip_ljubimca where vlasnik = "+idKorisnika;
            sql_cmd.ExecuteNonQuery();
            SQLiteDataReader dr = sql_cmd.ExecuteReader();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            DataSet ds = new DataSet();
            int idLjubimca = 1;
            
            while (dr.Read())
            {             
                idLjubimca = dr.GetInt32(0);
            }

            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView_vasiLjubimci.DataSource = dt;
                dataGridView_vasiLjubimci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sql_cmd1 = sql_con.CreateCommand();
            
            sql_cmd1.CommandText = "select pregledi.datum as datum_pregleda,ljubimci.naziv as ljubimac,pregledi.napomena as napomena,strftime('%H:%M', pregledi.vrijeme) as vrijeme from pregledi left join ljubimci on ljubimci.id_ljubimca = pregledi.ljubimac where pregledi.korisnik = " + idKorisnika + "and pregledi.datum >= date('now') order by datum,vrijeme asc";
            sql_cmd1.ExecuteNonQuery();
            SQLiteDataReader dr1 = sql_cmd1.ExecuteReader();
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(sql_cmd1);
            DataSet ds1 = new DataSet();
            try
            {
                da1.Fill(ds1);
                DataTable dt1 = ds1.Tables[0];
                dataGridView_zakazaniPregledi.DataSource = dt1;
                dataGridView_zakazaniPregledi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql_con.Close();

        }

        private void buttonPregled_Click(object sender, EventArgs e)
        {
            string vrijednost = dataGridView_vasiLjubimci.CurrentRow.Cells[0].Value.ToString();
            int vr = Convert.ToInt32(vrijednost);
            FormaPovijestBolesti povBolesti2 = new FormaPovijestBolesti(vr);
            povBolesti2.Show();
        }
    }
}
