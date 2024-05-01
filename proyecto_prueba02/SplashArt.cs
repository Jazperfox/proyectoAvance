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
    public partial class SplashArt : Form
    {
        public SplashArt()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PB1.Value<100)
            {
                PB1.Value++;
            }
            if(PB1.Value==100)
            {
                timer1.Enabled = false;
            }
            
            this.Close();
        }
    }
}
