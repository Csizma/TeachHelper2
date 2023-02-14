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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odbcConnection1.Open();
            odbcCommand1.Parameters[1].Value = AktualisFelhasznalok.ora;
            odbcCommand1.Parameters[0].Value = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            odbcCommand1.Parameters[2].Value = AktualisFelhasznalok.orak;
            odbcCommand1.Parameters[3].Value = AktualisFelhasznalok.nap;
            String nap = Convert.ToString(AktualisFelhasznalok.nap);
            if (nap == "1")
            {
                odbcCommand1.Parameters[3].Value = "Hétfő";
            } else if (nap == "2")
            {
                odbcCommand1.Parameters[3].Value = "Kedd";
            }
            else if (nap == "3")
            {
                odbcCommand1.Parameters[3].Value = "Szerda";
            }
            else if (nap == "4")
            {
                odbcCommand1.Parameters[3].Value = "Csütörtök";
            }
            else if (nap == "5")
            {
                odbcCommand1.Parameters[3].Value = "Péntek";
            }
            odbcCommand1.ExecuteNonQuery();
            odbcConnection1.Close();

        }

    }
}
