using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.AktualisFelhasznalok;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static String diak_id;
        public static String osztaly_id;
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AdatTablak.diak' table. You can move, or remove it, as needed.
            this.diakTableAdapter.Fill(this.AdatTablak.diak);

            tantargy.Text = AktualisFelhasznalok.aktualis_tantargy;
            ora.Text = AktualisFelhasznalok.ora;
            nap.Text = AktualisFelhasznalok.nap;
            datum.Text = AktualisFelhasznalok.datum;
            osztaly.Text = AktualisFelhasznalok.aktualis_osztaly;
            System.Data.Odbc.OdbcDataReader myreader;
            con.Open();
            dsOsztaly.Parameters[0].Value = AktualisFelhasznalok.aktualis_osztaly;
            //MessageBox.Show(Convert.ToString( odbcCommand1.Parameters[0].Value));


            myreader = dsOsztaly.ExecuteReader();
            
            if (myreader.Read())
            {
                osztaly_id = myreader.GetString(myreader.GetOrdinal("osztaly_id"));
                myreader.Close();
                try
                {
                    this.diakTableAdapter.FillBy(this.AdatTablak.diak, new System.Nullable<int>(((int)(System.Convert.ChangeType(osztaly_id, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                }
            }
            dsOsszehasonlit.Parameters[0].Value = Convert.ToString(osztaly_id);
            dsOsszehasonlit.Parameters[1].Value = Convert.ToString(osztaly_id);
                myreader = dsOsszehasonlit.ExecuteReader();
            if (myreader.Read())
            {
                diak_id = myreader.GetString(myreader.GetOrdinal("diak_id"));
                con.Close();

            }

            AktualisFelhasznalok.letszam = Convert.ToInt32(diak_id);
                string letszam = Convert.ToString(AktualisFelhasznalok.letszam);
                letsz.Text = letszam;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            hub f3 = new hub();
            f3.Show();
            this.Hide();
        }
    }

}
