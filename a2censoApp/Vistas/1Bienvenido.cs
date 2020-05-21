using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2censoApp
{
    public partial class frBienvenido : Form
    {
        public frBienvenido()
        {
            InitializeComponent();

            
            Bitmap img = new Bitmap(Application.StartupPath + @"\imgBienvenido\Bienvenida.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Vistas.Permisos abrir= new Vistas.Permisos();
            abrir.Show();
            this.Opacity = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
