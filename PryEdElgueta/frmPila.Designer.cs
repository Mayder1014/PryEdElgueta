namespace PryEdElgueta
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.mrcMostrar = new System.Windows.Forms.GroupBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.imgPila = new System.Windows.Forms.PictureBox();
            this.mrcEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblCodigoMostrar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mrcAgregar = new System.Windows.Forms.GroupBox();
            this.updCodigoA = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteA = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPila)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigoA)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcMostrar
            // 
            this.mrcMostrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mrcMostrar.Controls.Add(this.dgvMostrar);
            this.mrcMostrar.Controls.Add(this.lstMostrar);
            this.mrcMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcMostrar.Location = new System.Drawing.Point(23, 258);
            this.mrcMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcMostrar.Name = "mrcMostrar";
            this.mrcMostrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcMostrar.Size = new System.Drawing.Size(776, 286);
            this.mrcMostrar.TabIndex = 7;
            this.mrcMostrar.TabStop = false;
            this.mrcMostrar.Text = "Listado en una Lista y una Grilla";
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
            this.lstMostrar.Size = new System.Drawing.Size(240, 244);
            this.lstMostrar.TabIndex = 0;
            // 
            // imgPila
            // 
            this.imgPila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgPila.Image = ((System.Drawing.Image)(resources.GetObject("imgPila.Image")));
            this.imgPila.Location = new System.Drawing.Point(23, 12);
            this.imgPila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgPila.Name = "imgPila";
            this.imgPila.Size = new System.Drawing.Size(235, 224);
            this.imgPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPila.TabIndex = 6;
            this.imgPila.TabStop = false;
            // 
            // mrcEliminado
            // 
            this.mrcEliminado.BackColor = System.Drawing.Color.IndianRed;
            this.mrcEliminado.Controls.Add(this.lblTramiteMostrar);
            this.mrcEliminado.Controls.Add(this.lblNombreMostrar);
            this.mrcEliminado.Controls.Add(this.lblCodigoMostrar);
            this.mrcEliminado.Controls.Add(this.btnEliminar);
            this.mrcEliminado.Controls.Add(this.label4);
            this.mrcEliminado.Controls.Add(this.label5);
            this.mrcEliminado.Controls.Add(this.label6);
            this.mrcEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEliminado.Location = new System.Drawing.Point(553, 12);
            this.mrcEliminado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcEliminado.Size = new System.Drawing.Size(245, 224);
            this.mrcEliminado.TabIndex = 5;
            this.mrcEliminado.TabStop = false;
            this.mrcEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramiteMostrar
            // 
            this.lblTramiteMostrar.BackColor = System.Drawing.SystemColors.Window;
            this.lblTramiteMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteMostrar.Location = new System.Drawing.Point(77, 126);
            this.lblTramiteMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteMostrar.Name = "lblTramiteMostrar";
            this.lblTramiteMostrar.Size = new System.Drawing.Size(149, 23);
            this.lblTramiteMostrar.TabIndex = 11;
            this.lblTramiteMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTramiteMostrar.UseMnemonic = false;
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombreMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMostrar.Location = new System.Drawing.Point(77, 82);
            this.lblNombreMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(149, 23);
            this.lblNombreMostrar.TabIndex = 10;
            this.lblNombreMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombreMostrar.UseMnemonic = false;
            // 
            // lblCodigoMostrar
            // 
            this.lblCodigoMostrar.BackColor = System.Drawing.SystemColors.Window;
            this.lblCodigoMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMostrar.Location = new System.Drawing.Point(77, 38);
            this.lblCodigoMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMostrar.Name = "lblCodigoMostrar";
            this.lblCodigoMostrar.Size = new System.Drawing.Size(69, 23);
            this.lblCodigoMostrar.TabIndex = 9;
            this.lblCodigoMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigoMostrar.UseMnemonic = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(16, 171);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tramite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 39);
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
            this.mrcAgregar.Location = new System.Drawing.Point(292, 12);
            this.mrcAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcAgregar.Size = new System.Drawing.Size(245, 224);
            this.mrcAgregar.TabIndex = 4;
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
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 558);
            this.Controls.Add(this.mrcMostrar);
            this.Controls.Add(this.imgPila);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcAgregar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lineal - PILA";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.mrcMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPila)).EndInit();
            this.mrcEliminado.ResumeLayout(false);
            this.mrcEliminado.PerformLayout();
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigoA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcMostrar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.PictureBox imgPila;
        private System.Windows.Forms.GroupBox mrcEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox mrcAgregar;
        private System.Windows.Forms.NumericUpDown updCodigoA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteA;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTramiteMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
        private System.Windows.Forms.Label lblCodigoMostrar;
    }
}