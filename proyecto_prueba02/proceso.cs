using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_prueba02
{
    public partial class proceso : Form
    {
        public proceso()
        {
            InitializeComponent();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.ShowDialog();
        }

        private void proceso_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
    }
}
