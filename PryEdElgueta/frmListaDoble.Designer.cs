namespace PryEdElgueta
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.mrcMostrar = new System.Windows.Forms.GroupBox();
            this.cmbMostrar = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.imgCola = new System.Windows.Forms.PictureBox();
            this.mrcEliminado = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mrcAgregar = new System.Windows.Forms.GroupBox();
            this.updCodigoA = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteA = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.mrcMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigoA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcMostrar
            // 
            this.mrcMostrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mrcMostrar.Controls.Add(this.cmbMostrar);
            this.mrcMostrar.Controls.Add(this.dgvMostrar);
            this.mrcMostrar.Controls.Add(this.lstMostrar);
            this.mrcMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcMostrar.Location = new System.Drawing.Point(15, 260);
            this.mrcMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcMostrar.Name = "mrcMostrar";
            this.mrcMostrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcMostrar.Size = new System.Drawing.Size(776, 286);
            this.mrcMostrar.TabIndex = 11;
            this.mrcMostrar.TabStop = false;
            this.mrcMostrar.Text = "Listado en una Lista y una Grilla";
            // 
            // cmbMostrar
            // 
            this.cmbMostrar.FormattingEnabled = true;
            this.cmbMostrar.Location = new System.Drawing.Point(13, 244);
            this.cmbMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMostrar.Name = "cmbMostrar";
            this.cmbMostrar.Size = new System.Drawing.Size(240, 24);
            this.cmbMostrar.TabIndex = 2;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMostrar.Location = new System.Drawing.Point(269, 26);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(489, 244);
            this.dgvMostrar.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // lstMostrar
            // 
            this.lstMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.ItemHeight = 16;
            this.lstMostrar.Location = new System.Drawing.Point(13, 26);
            this.lstMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(240, 212);
            this.lstMostrar.TabIndex = 0;
            // 
            // imgCola
            // 
            this.imgCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgCola.Image = ((System.Drawing.Image)(resources.GetObject("imgCola.Image")));
            this.imgCola.Location = new System.Drawing.Point(15, 14);
            this.imgCola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCola.Name = "imgCola";
            this.imgCola.Size = new System.Drawing.Size(255, 224);
            this.imgCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCola.TabIndex = 10;
            this.imgCola.TabStop = false;
            // 
            // mrcEliminado
            // 
            this.mrcEliminado.BackColor = System.Drawing.Color.IndianRed;
            this.mrcEliminado.Controls.Add(this.cmbEliminar);
            this.mrcEliminado.Controls.Add(this.btnEliminar);
            this.mrcEliminado.Controls.Add(this.label6);
            this.mrcEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEliminado.Location = new System.Drawing.Point(544, 14);
            this.mrcEliminado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcEliminado.Size = new System.Drawing.Size(245, 122);
            this.mrcEliminado.TabIndex = 9;
            this.mrcEliminado.TabStop = false;
            this.mrcEliminado.Text = "Eliminar Elemento";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(77, 36);
            this.cmbEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(149, 24);
            this.cmbEliminar.TabIndex = 6;
            this.cmbEliminar.SelectedIndexChanged += new System.EventHandler(this.cmbEliminado_SelectedIndexChanged);
            this.cmbEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEliminar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(16, 76);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo:";
            // 
            // mrcAgregar
            // 
            this.mrcAgregar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.mrcAgregar.Controls.Add(this.updCodigoA);
            this.mrcAgregar.Controls.Add(this.btnAgregar);
            this.mrcAgregar.Controls.Add(this.txtTramiteA);
            this.mrcAgregar.Controls.Add(this.txtNombreA);
            this.mrcAgregar.Controls.Add(this.label3);
            this.mrcAgregar.Controls.Add(this.label2);
            this.mrcAgregar.Controls.Add(this.label1);
            this.mrcAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAgregar.Location = new System.Drawing.Point(283, 14);
            this.mrcAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcAgregar.Size = new System.Drawing.Size(245, 224);
            this.mrcAgregar.TabIndex = 8;
            this.mrcAgregar.TabStop = false;
            this.mrcAgregar.Text = "Nuevo Elemento";
            // 
            // updCodigoA
            // 
            this.updCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCodigoA.Location = new System.Drawing.Point(77, 38);
            this.updCodigoA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updCodigoA.Name = "updCodigoA";
            this.updCodigoA.Size = new System.Drawing.Size(81, 22);
            this.updCodigoA.TabIndex = 6;
            this.updCodigoA.ValueChanged += new System.EventHandler(this.updCodigoA_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(16, 171);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(212, 33);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteA
            // 
            this.txtTramiteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramiteA.Location = new System.Drawing.Point(77, 126);
            this.txtTramiteA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTramiteA.Name = "txtTramiteA";
            this.txtTramiteA.Size = new System.Drawing.Size(151, 22);
            this.txtTramiteA.TabIndex = 4;
            this.txtTramiteA.TextChanged += new System.EventHandler(this.txtTramiteA_TextChanged);
            this.txtTramiteA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTramiteA_KeyPress);
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreA.Location = new System.Drawing.Point(77, 82);
            this.txtNombreA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(151, 22);
            this.txtNombreA.TabIndex = 3;
            this.txtNombreA.TextChanged += new System.EventHandler(this.txtNombreA_TextChanged);
            this.txtNombreA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.optDescendente);
            this.groupBox1.Controls.Add(this.optAscendente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(544, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 95);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Datos";
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDescendente.Location = new System.Drawing.Point(21, 57);
            this.optDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(113, 21);
            this.optDescendente.TabIndex = 1;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Checked = true;
            this.optAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAscendente.Location = new System.Drawing.Point(21, 25);
            this.optAscendente.Margin = new System.Windows.Forms.Padding(4);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(104, 21);
            this.optAscendente.TabIndex = 0;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcMostrar);
            this.Controls.Add(this.imgCola);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lineal - Lista Doble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.mrcMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).EndInit();
            this.mrcEliminado.ResumeLayout(false);
            this.mrcEliminado.PerformLayout();
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigoA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcMostrar;
        private System.Windows.Forms.ComboBox cmbMostrar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.PictureBox imgCola;
        private System.Windows.Forms.GroupBox mrcEliminado;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox mrcAgregar;
        private System.Windows.Forms.NumericUpDown updCodigoA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteA;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optAscendente;
        private System.Windows.Forms.RadioButton optDescendente;
    }
}