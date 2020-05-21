using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2censoApp.Vistas
{
    public partial class DatosGuardados : Form
    {
        public DatosGuardados()
        {
            InitializeComponent();
        }

        private void btmContinuar_Click(object sender, EventArgs e)
        {
            Vistas._5InstruccionesExperimento abrir = new _5InstruccionesExperimento();
            abrir.Show();
            this.Close();
        }

        private void DatosGuardados_Load(object sender, EventArgs e)
        {

        }
    }
}
