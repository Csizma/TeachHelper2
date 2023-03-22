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

        private void Form6_Load(object sender, EventArgs e)
        {
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
            AktualisFelhasznalok.aktualis_tantargy = tantargy.Text;
            AktualisFelhasznalok.aktualis_osztaly = osztaly.Text;
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
