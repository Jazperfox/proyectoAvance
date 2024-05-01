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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }
        conectarBD bd = new conectarBD();

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            bd.cnn.Open();
            string queryselect= "select Rango from rangoSeguridad";
            SqlCommand comand = new SqlCommand(queryselect,bd.cnn);
            SqlDataReader lector = comand.ExecuteReader();
            while(lector.Read())
            {
                cbxRango.Items.Add(lector.GetString(0));
            }
            bd.cnn.Close();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text + " " + txtapellido.Text;

            bd.insertarUsuario(txtUsuario.Text, nombre, Convert.ToInt32(txtedad.Text), cbxRango.SelectedIndex + 1, txtpws.Text);

            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtpws.Text = "";
            cbxRango.Text = "";
           
        }
    }
}
