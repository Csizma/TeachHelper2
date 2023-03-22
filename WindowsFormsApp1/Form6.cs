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
            // TODO: This line of code loads data into the 'adatTablak.jelenlet' table. You can move, or remove it, as needed.
            this.jelenletTableAdapter.Fill(this.adatTablak.jelenlet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            odbcCommand1.Parameters[0].Value = rjTextBox1.Text;
            odbcCommand1.Parameters[1].Value = rjTextBox2.Text;
            odbcCommand1.Parameters[2].Value = rjTextBox3.Text;
            odbcCommand1.Parameters[3].Value = rjTextBox4.Text;


        }
    }
}
