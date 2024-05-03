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
    public partial class ListaUsuarios : Form
    {
        DataTable dt = new DataTable();
        public ListaUsuarios()
        {
            InitializeComponent();
            conectarBD bd = new conectarBD();
            bd.cnn.Open();
            string consulta = "select id_Usuario as Usuario,nombre as Nombre,Rango from usuario join rangoSeguridad on usuario.idRango=rangoSeguridad.idRango";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, bd.cnn);

            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            bd.cnn.Close();
        }

        private void filtrar(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = $"Nombre like '{txtfiltro.Text}%'";
        }
    }
}
