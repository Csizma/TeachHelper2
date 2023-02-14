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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            odbcConnection1.Open();
            AktualisFelhasznalok.orak = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            AktualisFelhasznalok.nap = Convert.ToString(dataGridView1.SelectedCells[0].ColumnIndex.ToString());
            AktualisFelhasznalok.ora = dataGridView1.SelectedCells[0].Value;
            
            System.Data.Odbc.OdbcDataReader myreader;
            odbcCommand3.Parameters[0].Value = AktualisFelhasznalok.ora;
            odbcCommand3.Parameters[1].Value = AktualisFelhasznalok.nap;
            odbcCommand3.Parameters[2].Value = AktualisFelhasznalok.osztaly;
            odbcCommand3.Parameters[3].Value = AktualisFelhasznalok.orak;
            /*MessageBox.Show(Convert.ToString(odbcCommand3.Parameters[0].Value));
            MessageBox.Show(Convert.ToString(odbcCommand3.Parameters[1].Value));
            MessageBox.Show(Convert.ToString(odbcCommand3.Parameters[2].Value));
            MessageBox.Show(Convert.ToString(odbcCommand3.Parameters[3].Value));*/
            myreader = odbcCommand3.ExecuteReader();
            string test;

            if (myreader.Read())
            {
                test = myreader.GetString(myreader.GetOrdinal("naplo"));
                int test2 = Convert.ToInt16(test);
                Console.WriteLine(test2);
                if (test2 == 1)
                {
                    MessageBox.Show("Ez az óra már naplózásra került!", "TeachHelper");
                    odbcConnection1.Close();
                }
                else
                {


                    odbcConnection1.Close();
                        Form5 f2 = new Form5();
                        f2.Show();

                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            timer1.Start();
            odbcConnection1.Open();
            odbcCommand1.Parameters[0].Value = AktualisFelhasznalok.aktualis_felhasznalo;

            odbcCommand1.ExecuteNonQuery();
            try
            {
                this.orarendTableAdapter.Fill(this.teachhelperDataSet5.orarend);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            odbcDataAdapter1.Fill(this.teachhelperDataSet5, AktualisFelhasznalok.aktualis_felhasznalo);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            odbcConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odbcConnection1.Open();
            odbcCommand1.ExecuteNonQuery();
            odbcConnection1.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datum.Text = DateTime.Now.ToShortDateString();
            ido.Text = DateTime.Now.ToShortTimeString();
        }

        private void orarend1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }
    }
}
