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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imgBienvenido\Bienvenida.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtCorreo.Text!="")
            {
               
                // 
                // bntContinuar
                // 
                this.bntContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                this.bntContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.bntContinuar.Location = new System.Drawing.Point(448, 12);
                this.bntContinuar.Name = "bntContinuar";
                this.bntContinuar.Size = new System.Drawing.Size(135, 42);
                this.bntContinuar.TabIndex = 1;
                this.bntContinuar.Text = "Continuar";
                this.bntContinuar.UseVisualStyleBackColor = false;
                this.bntContinuar.Click += new System.EventHandler(this.bntContinuar_Click);

                 

            }
            else
            {
    
                // 
                // lbFaltanCampos
                // 
                this.lbFaltanCampos.AutoSize = true;
                this.lbFaltanCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lbFaltanCampos.ForeColor = System.Drawing.Color.Red;
                this.lbFaltanCampos.Location = new System.Drawing.Point(124, 313);
                this.lbFaltanCampos.Name = "lbFaltanCampos";
                this.lbFaltanCampos.Size = new System.Drawing.Size(217, 24);
                this.lbFaltanCampos.TabIndex = 14;
                this.lbFaltanCampos.Text = "Faltan campos por llenar";
               
                string txt1 = txtNombres.Text;
                if (txt1 =="" )
                {
                    // 
                    // txtNombres
                    // 
                    this.txtNombres.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    // 
                    // txtNombres
                    // 
                    this.txtNombres.BackColor = System.Drawing.Color.White;
                }

                string txt2 = txtApellidos.Text;
                if (txt2 == "")
                {
                    // 
                    // txtApellidos
                    // 
                    this.txtApellidos.BackColor = System.Drawing.Color.Red;

                }
                else
                {
                    // 
                    // txtApellidos
                    // 
                    this.txtApellidos.BackColor = System.Drawing.Color.White;
                }

                string txt3 = txtCorreo.Text;
                if (txt3 == "")
                {
                    // 
                    // txtCorreo
                    // 
                    this.txtCorreo.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    // 
                    // txtCorreo
                    // 
                    this.txtCorreo.BackColor = System.Drawing.Color.White;
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bntContinuar_Click(object sender, EventArgs e)
        {
            Vistas.DatosGuardados abrir = new Vistas.DatosGuardados();
            abrir.Show();
            this.Close();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            
            
        }
        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
