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

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adatTablak.tantargy' table. You can move, or remove it, as needed.
            this.tantargyTableAdapter.Fill(this.adatTablak.tantargy);
            // TODO: This line of code loads data into the 'adatTablak.osztaly' table. You can move, or remove it, as needed.
            this.osztalyTableAdapter.Fill(this.adatTablak.osztaly);

            tol.Texts = AktualisFelhasznalok.date;
            ig.Texts = AktualisFelhasznalok.date;
            System.Data.Odbc.OdbcDataReader myreader;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            System.Data.Odbc.OdbcDataReader myreader;
            String toltarol = Convert.ToString(tol.Texts);
            String igtarol = Convert.ToString(ig.Texts);
            //int tantargy_idk = Convert.ToInt32(tantargyak_combo.Texts);
            con.Open();
            dsTantargyParameter.Parameters[0].Value = tantargyak_combo.Text;

            myreader = dsTantargyParameter.ExecuteReader();
            //MessageBox.Show(Convert.ToString(dsTantargyParameter.Parameters[0].Value));
            string test;
            
            
            if (myreader.Read())
            {
                test = myreader.GetString(myreader.GetOrdinal("tantargy_id"));
                //MessageBox.Show(test);

                dsOSztalyNevId.Parameters[0].Value = osztaly.Text;
                myreader = dsOSztalyNevId.ExecuteReader();

                string osztalyid_kiir;

                if (myreader.Read())
                {
                    osztalyid_kiir = myreader.GetString(myreader.GetOrdinal("osztaly_id"));

                
                try
                {
                    this.jelenletTableAdapter.FillBy(this.adatTablak.jelenlet, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(toltarol, typeof(System.DateTime))))),new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(igtarol, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(test, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(osztalyid_kiir, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                }
                con.Close();
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    con.Open();
                    if (row.Cells[1].Value != null)
                    {
                        //MessageBox.Show(Convert.ToString( row.Cells[1].Value));
                        dsNevek.Parameters.AddWithValue("nevek", row.Cells[1].Value);
                        dsNevek.ExecuteNonQuery();

                        myreader = dsNevek.ExecuteReader();

                        string nevek_kíír;

                        if (myreader.Read())
                        {
                            nevek_kíír = myreader.GetString(myreader.GetOrdinal("diak_nev"));
                            row.Cells[2].Value = nevek_kíír;
                            //myreader.Close();
                            con.Close();

                        }
                        dsNevek.Parameters.Clear();
                    }
                }
                con.Close();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[6].Value != null)
                    {
                        int jelenlet_kiir = Convert.ToInt32(row.Cells[6].Value) ;
                            if (jelenlet_kiir == 0)
                            {
                                row.Cells[7].Value = "Hiányzás";
                            }
                            else if (jelenlet_kiir == 1)
                            {
                                row.Cells[7].Value = "Jelen";
                            }


                        
                        
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    con.Open();
                    if (row.Cells[1].Value != null)
                    {
                        dsOsztaly_id.Parameters.AddWithValue("osztaly_id", row.Cells[1].Value);
                        dsOsztaly_id.ExecuteNonQuery();
                        //MessageBox.Show(Convert.ToString( dsJelenlet.Parameters[0].Value));

                        myreader = dsOsztaly_id.ExecuteReader();

                        string osztaly_kiir;

                        if (myreader.Read())
                        {
                            osztaly_kiir = myreader.GetString(myreader.GetOrdinal("osztaly_id"));
                            row.Cells[8].Value = osztaly_kiir;

                        }


                        con.Close();
                        dsOsztaly_id.Parameters.Clear();

                    }
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    con.Open();
                    if (row.Cells[8].Value != null)
                    {
                        dsOsztaly_nev.Parameters.AddWithValue("osztaly_nev", row.Cells[8].Value);
                        dsOsztaly_nev.ExecuteNonQuery();
                        //MessageBox.Show(Convert.ToString( dsJelenlet.Parameters[0].Value));

                        myreader = dsOsztaly_nev.ExecuteReader();

                        string osztalynev_kiir;

                        if (myreader.Read())
                        {
                            osztalynev_kiir = myreader.GetString(myreader.GetOrdinal("osztaly_nev"));
                            row.Cells[8].Value = osztalynev_kiir;

                        }


                        con.Close();
                        dsOsztaly_nev.Parameters.Clear();

                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    con.Open();
                    if (row.Cells[2].Value != null)
                    {
                        //MessageBox.Show(Convert.ToString( row.Cells[1].Value));
                        dsTantargy.Parameters.AddWithValue("tantárgy", row.Cells[3].Value);
                        dsTantargy.ExecuteNonQuery();

                        myreader = dsTantargy.ExecuteReader();

                        string tantargy_kiir;

                        if (myreader.Read())
                        {
                            tantargy_kiir = myreader.GetString(myreader.GetOrdinal("tantargy_nev"));
                            row.Cells[4].Value = tantargy_kiir;

                        }
                        con.Close();
                        dsTantargy.Parameters.Clear();
                    }
                }
                odbcCommand1.Parameters[0].Value = ig.Text;
                odbcCommand1.Parameters[1].Value = tol.Text;
                odbcCommand1.Parameters[2].Value = tantargyak_combo.Text;
                odbcCommand1.Parameters[3].Value = osztaly.Text;
            }
            con.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            System.Data.Odbc.OdbcDataReader myreader;
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            hub f3 = new hub();
            f3.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabelLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tol__TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
