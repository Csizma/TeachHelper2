using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Spire.Pdf.Tables;
using Spire.Pdf.Exporting.XPS.Schema;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.AktualisFelhasznalok;

namespace WindowsFormsApp1
{
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();
        }
        Boolean eye = false;
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion
        private void Regisztracio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }
        
        private void Regisztracio_Load(object sender, EventArgs e)
        {
            fullname.Text = "Teljes név";
            username.Text = "Felhasználónév";
            email.Text = "Email cím";
            password.Text = "Jelszó";
            password2.Text = "Jelszó újra";
            

        }

        private void fullname_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "Teljes név")
            {
                fullname.Text = "";
            }
        }

        private void fullname_Leave(object sender, EventArgs e)
        {
            if (fullname.Text == "")
            {
                fullname.Text = "Teljes név";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Felhasználónév";
            }
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text == "Felhasználónév")
            {
                username.Text = "";
            }
        }

        private void email_Click(object sender, EventArgs e)
        {
            if (email.Text == "Email cím")
            {
                email.Text = "";
            }

        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email cím";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Jelszó";
                password.PasswordChar = '\0';
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text == "Jelszó")
            {
                password.Text = "";
                password.PasswordChar = '*';
            }
        }
        private void password2_Leave(object sender, EventArgs e)
        {
            if (password2.Text == "")
            {
                password2.Text = "Jelszó újra";
                password2.PasswordChar = '\0';
            }
        }

        private void password2_Click(object sender, EventArgs e)
        {
            if (password2.Text == "Jelszó újra")
            {
                password2.Text = "";
                password2.PasswordChar = '*';
            }
        }

        private void reg_Click(object sender, EventArgs e)
        {

            conTeachHelper.Open();

            cmdRegisztracio.Parameters[0].Value = email.Text;
            cmdRegisztracio.Parameters[1].Value = username.Text;
            cmdRegisztracio.Parameters[2].Value = password.Text;
            cmdRegisztracio.Parameters[3].Value = fullname.Text;


            //cmdBejelentkezes.ExecuteReader().GetName(0);
            cmdBejelentkezes.Parameters[0].Value = username.Text;
            cmdBejelentkezes.Parameters[1].Value = password.Text;
            
            System.Data.Odbc.OdbcDataReader myreader;
            
            myreader = cmdBejelentkezes.ExecuteReader();
            string test;

            if (myreader.Read())
            {
                test = myreader.GetString(myreader.GetOrdinal("c_felh"));
                int test2 = Convert.ToInt16(test);
                Console.WriteLine(test2);
                if (test2 == 1)
                {
                    MessageBox.Show("Már létező fiók!", "TeachHelper");
                    conTeachHelper.Close();
                }
                else
                {
                    cmdRegisztracio.ExecuteNonQuery();
                    DialogResult result = MessageBox.Show("Sikeres regisztráció!", "TeachHelper");

                  
                    conTeachHelper.Close();
                    if (result == DialogResult.OK)
                    {
                        Login f2 = new Login();
                        f2.Show();
                        this.Hide();
                    }

                }
            }

            
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (eye == false)
            {
                password.PasswordChar = '\0';
                password2.PasswordChar = '\0';
                this.pictureBox6.BackgroundImage = Properties.Resources.eye_open;
                eye = true;
            }
            else
            {
                password.PasswordChar = '*';
                password2.PasswordChar = '*';
                this.pictureBox6.BackgroundImage = Properties.Resources.eye_close;
                eye = false;
            }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text == "Jelszó")
            {
                password.Text = "";
                password.PasswordChar = '*';
            }
        }

        private void password2_Enter(object sender, EventArgs e)
        {
            if (password2.Text == "Jelszó újra")
            {
                password2.Text = "";
                password2.PasswordChar = '*';
            }
        }
    }
}
