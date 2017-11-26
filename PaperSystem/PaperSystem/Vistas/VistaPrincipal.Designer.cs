namespace PaperSystem.Vistas
{
    partial class VistaPrincipal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Productos = new System.Windows.Forms.Button();
            this.Utilerías = new System.Windows.Forms.Button();
            this.Impresiones = new System.Windows.Forms.Button();
            this.Copias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "EDITORIAL ITH";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PaperSystem.Properties.Resources.logo_ith;
            this.pictureBox2.Location = new System.Drawing.Point(45, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Productos);
            this.panel1.Controls.Add(this.Utilerías);
            this.panel1.Controls.Add(this.Impresiones);
            this.panel1.Controls.Add(this.Copias);
            this.panel1.Location = new System.Drawing.Point(283, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 299);
            this.panel1.TabIndex = 21;
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.Ivory;
            this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.Color.Green;
            this.Productos.Location = new System.Drawing.Point(3, 134);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(143, 61);
            this.Productos.TabIndex = 34;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = false;
            // 
            // Utilerías
            // 
            this.Utilerías.BackColor = System.Drawing.Color.Ivory;
            this.Utilerías.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilerías.ForeColor = System.Drawing.Color.Green;
            this.Utilerías.Location = new System.Drawing.Point(185, 134);
            this.Utilerías.Name = "Utilerías";
            this.Utilerías.Size = new System.Drawing.Size(143, 61);
            this.Utilerías.TabIndex = 33;
            this.Utilerías.Text = "Utilerías";
            this.Utilerías.UseVisualStyleBackColor = false;
            // 
            // Impresiones
            // 
            this.Impresiones.BackColor = System.Drawing.Color.Ivory;
            this.Impresiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impresiones.ForeColor = System.Drawing.Color.Green;
            this.Impresiones.Location = new System.Drawing.Point(185, 3);
            this.Impresiones.Name = "Impresiones";
            this.Impresiones.Size = new System.Drawing.Size(143, 56);
            this.Impresiones.TabIndex = 32;
            this.Impresiones.Text = "Impresiones";
            this.Impresiones.UseVisualStyleBackColor = false;
            // 
            // Copias
            // 
            this.Copias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Copias.BackColor = System.Drawing.Color.Ivory;
            this.Copias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copias.ForeColor = System.Drawing.Color.Green;
            this.Copias.Location = new System.Drawing.Point(3, 3);
            this.Copias.Name = "Copias";
            this.Copias.Size = new System.Drawing.Size(143, 56);
            this.Copias.TabIndex = 31;
            this.Copias.Text = "Copias";
            this.Copias.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Administración de usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Respaldo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Name = "VistaPrincipal";
            this.Size = new System.Drawing.Size(628, 315);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Button Utilerías;
        private System.Windows.Forms.Button Impresiones;
        private System.Windows.Forms.Button Copias;
        private System.Windows.Forms.Button button2;
    }
}
