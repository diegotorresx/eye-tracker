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
    public partial class _5InstruccionesExperimento : Form
    {
        static int i = 0;
        static int j = 0;
        static int k = 0;
        public _5InstruccionesExperimento()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imgBienvenido\Rectangle.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void _5InstruccionesExperimento_Load(object sender, EventArgs e)
        {

        }

        

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            i++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            j++;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            k++;
        }
        private void btmContinuar_Click(object sender, EventArgs e)
        {
           if (i>=1 && j>=1 && k>=1)
            {
                Vistas._6EspecificacionesLuzcs abrir = new _6EspecificacionesLuzcs();
                
            }
            else
            {
                // 
                // lbFaltantes
                // 
                this.lbFaltantes.AutoSize = true;
                this.lbFaltantes.BackColor = System.Drawing.Color.Transparent;
                this.lbFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lbFaltantes.ForeColor = System.Drawing.Color.Red;
                this.lbFaltantes.Location = new System.Drawing.Point(1396, 924);
                this.lbFaltantes.Name = "lbFaltantes";
                this.lbFaltantes.Size = new System.Drawing.Size(194, 20);
                this.lbFaltantes.TabIndex = 11;
                this.lbFaltantes.Text = "Faltan botones por oprimir";
            }
        }
    }
}
