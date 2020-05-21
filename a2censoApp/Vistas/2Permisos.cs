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
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imgBienvenido\Bienvenida.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Permisos_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNoAceptar_Click(object sender, EventArgs e)
        {
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(197, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Debe aceptar los terminos para continuar";
            this.label3.Click += new System.EventHandler(this.label3_Click);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAcepto_Click(object sender, EventArgs e)
        {   
            if (checkTerminos.Checked==true)
            {
                Vistas.InicioSesion abrir = new Vistas.InicioSesion();
                abrir.Show();
                this.Close();
                
                
            }
            else
            {
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label4.ForeColor = System.Drawing.Color.Red;
                this.label4.Location = new System.Drawing.Point(606, 3);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(318, 20);
                this.label4.TabIndex = 2;
                this.label4.Text = "Debe leer y aceptar terminos para continuar";
                // 
            }

        }
    }
}
