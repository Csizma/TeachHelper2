using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.AktualisFelhasznalok;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace WindowsFormsApp1
{


    public partial class Login : Form
    {
        Boolean eye = false;
        public Login()
        {
            InitializeComponent();

        }
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

        private void Login_Load(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            AktualisFelhasznalok.date = date;
            username.Text = "Felhasználónév";
            password.Text = "Jelszó";

        }

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text == "Felhasználónév")
            {
                username.Text = "";
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

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Felhasználónév";
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


     
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            Regisztracio f2 = new Regisztracio();
            f2.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (eye == false) { 
            password.PasswordChar = '\0';
            this.pictureBox5.BackgroundImage = Resources.eye_open;
            eye = true;
            }
            else
            {
                    password.PasswordChar = '*';
                    this.pictureBox5.BackgroundImage = Resources.eye_close;
                    eye = false;
            }
            

        }

        private void log_button_Click(object sender, EventArgs e)
        {
            AktualisFelhasznalok.aktualis_felhasznalo = username.Text;
            AktualisFelhasznalok.aktualis_jelszo = password.Text;
            conTeachHelper.Open();
            cmdBejelentkezes.Parameters[0].Value = username.Text;
            cmdBejelentkezes.Parameters[1].Value = password.Text;
            
            //cmdBejelentkezes.ExecuteReader().GetName(0);
            System.Data.Odbc.OdbcDataReader myreader;

            myreader = cmdBejelentkezes.ExecuteReader();
            //myreader = odbcCommand1.ExecuteReader();



            string test;

            if (myreader.Read())
            {
                test = myreader.GetString(myreader.GetOrdinal("c_felh"));
                //MessageBox.Show(test);
                if (Convert.ToInt32(test) == 1) 
                {
                    hub f2 = new hub();
                    f2.Show();
                    this.Hide();

                }else
                {
                    DialogResult result = MessageBox.Show("Helytelen adatok!", "TeachHelper");
                    if (result == DialogResult.OK)
                    {
                        username.Text = "Felhasználónév";
                        password.Text = "Jelszó";
                        password.PasswordChar = '\0';
                    }
                }

            }

            

            /*
            if (cmdBejelentkezes.Parameters[0].Value == username.Text && cmdBejelentkezes.Parameters[1].Value == password.Text)
            {
                cmdBejelentkezes.ExecuteNonQuery();
                MessageBox.Show("cső");
            }
            */
            conTeachHelper.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Jelszó")
            {
                password.Text = "";
                password.PasswordChar = '*';
            }
        }
    }
}
