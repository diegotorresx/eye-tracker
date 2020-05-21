using System.Windows.Forms;

namespace a2censoApp
{
    partial class frBienvenido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBienvenido));
            this.btmInicio = new System.Windows.Forms.Button();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btmInicio
            // 
            this.btmInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInicio.Location = new System.Drawing.Point(892, 821);
            this.btmInicio.Name = "btmInicio";
            this.btmInicio.Size = new System.Drawing.Size(129, 46);
            this.btmInicio.TabIndex = 0;
            this.btmInicio.Text = "Iniciar";
            this.btmInicio.UseVisualStyleBackColor = false;
            this.btmInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.ForeColor = System.Drawing.Color.White;
            this.lbBienvenido.Location = new System.Drawing.Point(657, 320);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(616, 207);
            this.lbBienvenido.TabIndex = 1;
            this.lbBienvenido.Text = "BIENVENIDO\r\n  ";
            this.lbBienvenido.UseCompatibleTextRendering = true;
            this.lbBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(954, 110);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recuerde que para esta prueba necesitará \r\nun tiempo apriximado de 30 minutos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label1.Location = new System.Drawing.Point(518, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 110);
            this.label1.TabIndex = 4;
            this.label1.Text = "a la prueba de usabilidad de la Página\r\na2censo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1927, 466);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 680);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1927, 383);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // frBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBienvenido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmInicio);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1940, 1100);
            this.MinimizeBox = false;
            this.Name = "frBienvenido";
            this.Text = "a2censo";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmInicio;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}

