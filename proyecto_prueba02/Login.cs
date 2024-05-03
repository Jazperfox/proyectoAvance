using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_prueba02
{
    public partial class Login : Form
    {
        conectarBD bd = new conectarBD();

        public Login()
        {
            InitializeComponent();
        }

        private void UserLeave(object sender, EventArgs e)
        {
            if(txtUser.Text=="")
            {
                txtUser.Text = "Ingrese su Usuario";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void UserInsert(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.ForeColor = Color.Black;
        }

        private void PasswordInsert(object sender, EventArgs e)
        {
             if (txtpassword.Text == "inserte su contraseña")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void PasswordLeave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "inserte su contraseña";
                txtpassword.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result =bd.Login(txtUser.Text, txtpassword.Text);

            if (result == 1)
            {
                this.Close();
                

            }
            else if (result == 0)
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
        }


        /// <summary>
        /// transfiere el nivel de acceso del usuario
        /// </summary>
        /// <returns></returns>
        public string transferir()
        {
            return bd.V_Rango(txtUser.Text);
        }
    }
}
