using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string osztaly_id_ertek;
        public static int tanar_id_ertek;

        private void Form6_Load(object sender, EventArgs e)
        {
            Osztaly_valaszto.AnimateWindow(this.Handle, 700, Osztaly_valaszto.HOR_NEGATIVE);
            // TODO: This line of code loads data into the 'teachhelperDataSet5.osztaly' table. You can move, or remove it, as needed.
            this.osztalyTableAdapter.Fill(this.AdatTablak.osztaly);
            // TODO: This line of code loads data into the 'teachhelperDataSet5.tantargy' table. You can move, or remove it, as needed.
            this.tantargyTableAdapter1.Fill(this.AdatTablak.tantargy);

            timer1.Start();
            datum.Text = DateTime.Now.ToShortDateString();
            ido.Text = DateTime.Now.ToShortTimeString();
            DateTime now = DateTime.Now;
            string mai_nap = Convert.ToString(now.DayOfWeek);
            if (mai_nap == "Monday")
            { 
            nap.Text = "Hétfő";
            }
            else if (mai_nap == "Tuesday")
            {
                nap.Text = "Kedd";
            }
            else if (mai_nap == "Wednesday")
            {
                nap.Text = "Szerda";
            }
            else if (mai_nap == "Thursday")
            {
                nap.Text = "Csütörtök";
            }
            else if (mai_nap == "Friday")
            {
                nap.Text = "Péntek";
            }
            else if (mai_nap == "Saturday")
            {
                nap.Text = "Szombat";
            }
            else if (mai_nap == "Sunday")
            {
                nap.Text = "Vasárnap";
            }
            AktualisFelhasznalok.ora = DateTime.Now.ToShortTimeString();
            AktualisFelhasznalok.datum = DateTime.Now.ToShortDateString();
            AktualisFelhasznalok.nap = nap.Text;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dsMent.Parameters[0].Value = osztaly.Text;
            dsMent.Parameters[1].Value = AktualisFelhasznalok.aktualis_felhasznalo;
            System.Data.Odbc.OdbcDataReader myreader;
            odbcConnection1.Open();
            myreader = dsMent.ExecuteReader();

            if (myreader.Read())
            {
                osztaly_id_ertek = myreader.GetString(myreader.GetOrdinal("osztalyid"));
                tanar_id_ertek =  myreader.GetInt32(myreader.GetOrdinal("tanarid"));
                //MessageBox.Show(osztaly_id_ertek);
                //MessageBox.Show(Convert.ToString(tanar_id_ertek));
                myreader.Close();
                
            }

            myreader = dsTantargyid.ExecuteReader();
            dsTantargyid.Parameters[0].Value = tanar_id_ertek;
            if (myreader.Read())
            {
                string tantargy_id_ertek = myreader.GetString(myreader.GetOrdinal("tantargy_id"));
                //MessageBox.Show(tantargy_id_ertek);
                myreader.Close();

            }
            AktualisFelhasznalok.aktualis_osztaly_id = Convert.ToInt32(osztaly_id_ertek);
            AktualisFelhasznalok.aktualis_tanar_id = Convert.ToInt32(tanar_id_ertek);
            AktualisFelhasznalok.aktualis_tantargy = tantargy.Text;
            AktualisFelhasznalok.aktualis_osztaly = osztaly.Text;
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hub f3 = new hub();
            f3.Show();
            this.Hide();
        }
    }
}
