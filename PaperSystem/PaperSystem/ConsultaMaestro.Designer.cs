namespace PaperSystem
{
    partial class ConsultaMaestro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMaestro));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBuscarMaestro = new System.Windows.Forms.DataGridView();
            this.NumMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscarmaestro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Soberana Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(31, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lista de Maestro:";
            // 
            // dgvBuscarMaestro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Soberana Sans", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvBuscarMaestro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscarMaestro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscarMaestro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscarMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMaestro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMaestro,
            this.NomMaestro,
            this.AreaMaestro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Soberana Sans", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscarMaestro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscarMaestro.Location = new System.Drawing.Point(49, 172);
            this.dgvBuscarMaestro.Name = "dgvBuscarMaestro";
            this.dgvBuscarMaestro.Size = new System.Drawing.Size(635, 150);
            this.dgvBuscarMaestro.TabIndex = 22;
            // 
            // NumMaestro
            // 
            this.NumMaestro.HeaderText = "Numero del Maestro";
            this.NumMaestro.Name = "NumMaestro";
            this.NumMaestro.ReadOnly = true;
            // 
            // NomMaestro
            // 
            this.NomMaestro.HeaderText = "Nombre del Maestro";
            this.NomMaestro.Name = "NomMaestro";
            this.NomMaestro.ReadOnly = true;
            // 
            // AreaMaestro
            // 
            this.AreaMaestro.HeaderText = "Area del Maestro";
            this.AreaMaestro.Name = "AreaMaestro";
            this.AreaMaestro.ReadOnly = true;
            // 
            // txt_buscarmaestro
            // 
            this.txt_buscarmaestro.Font = new System.Drawing.Font("Soberana Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txt_buscarmaestro.Location = new System.Drawing.Point(397, 111);
            this.txt_buscarmaestro.MaxLength = 5;
            this.txt_buscarmaestro.Name = "txt_buscarmaestro";
            this.txt_buscarmaestro.Size = new System.Drawing.Size(100, 28);
            this.txt_buscarmaestro.TabIndex = 20;
            this.txt_buscarmaestro.TextChanged += new System.EventHandler(this.txt_buscarmaestro_TextChanged);
            this.txt_buscarmaestro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarmaestro_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Soberana Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(31, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Buscar Maestro Por su Numero de control:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Soberana Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(609, 362);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 30);
            this.btn_salir.TabIndex = 34;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(14, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 267);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // ConsultaMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::PaperSystem.Properties.Resources.Lineas_Naranja;
            this.ClientSize = new System.Drawing.Size(727, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBuscarMaestro);
            this.Controls.Add(this.txt_buscarmaestro);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaMaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Maestro";
            this.Load += new System.EventHandler(this.ConsultaMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBuscarMaestro;
        private System.Windows.Forms.TextBox txt_buscarmaestro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaMaestro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}