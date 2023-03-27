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
        public static int osztaly_id;
        public static String tantargy_id;
        private void Form5_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'AdatTablak.diak' table. You can move, or remove it, as needed.

            
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
                osztaly_id =Convert.ToInt32( myreader.GetString(myreader.GetOrdinal("osztaly_id")));
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
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                row.Cells[2].Value = true; // Az első CheckBox oszlop alapértelmezett értéke bejelölt
                row.Cells[2].Value = true; // 

            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            hub f3 = new hub();
            f3.Show();
            this.Hide();
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {
            System.Data.Odbc.OdbcDataReader myreader;
            con.Open();
            dsTantargy.Parameters[0].Value = tantargy.Text;
            
            myreader = dsTantargy.ExecuteReader();

            if (myreader.Read())
            {
                tantargy_id = myreader.GetString(myreader.GetOrdinal("tantargyid"));
                MessageBox.Show(tantargy_id);
            }
            con.Close();
            int presence;
            con.Open();
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    
                    String date = DateTime.Now.ToString("yyyy-MM-dd");
                    AktualisFelhasznalok.date = date;

                    ///adatok
                    dsFeltolt.Parameters.AddWithValue("diak_id",row.Cells[0].Value);
                    dsFeltolt.Parameters.AddWithValue("tantargyid", tantargy_id);
                    dsFeltolt.Parameters.AddWithValue("datum", date);
                    
                    ///adatok
                    
                    String row2 = Convert.ToString(row.Cells[2].Value);
                    
                    if (row2 == "True")
                    {
                        presence = 1;
                        dsFeltolt.Parameters.AddWithValue("jelenlet",presence);
                        dsFeltolt.Parameters.AddWithValue("osztalyid", Convert.ToInt32(osztaly_id));


                        //MessageBox.Show(Convert.ToString(dsFeltolt.Parameters[1].Value));
                    }
                    else if (row2 == "False")
                    {
                        presence = 0;
                        dsFeltolt.Parameters.AddWithValue("jelenlet", presence);
                        dsFeltolt.Parameters.AddWithValue("osztalyid", Convert.ToInt32(osztaly_id));
                        //feltöltés
                        //MessageBox.Show(Convert.ToString(dsFeltolt.Parameters[1].Value));
                    }
                    dsFeltolt.ExecuteNonQuery();
                    dsFeltolt.Parameters.Clear();


                }
               

            } MessageBox.Show("A naplózás sikeres!");
            con.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

}
