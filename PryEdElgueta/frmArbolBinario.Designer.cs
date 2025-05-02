namespace PryEdElgueta
{
    partial class frmArbolBinario
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
            this.mrcMostrar = new System.Windows.Forms.GroupBox();
            this.optPost = new System.Windows.Forms.RadioButton();
            this.optPre = new System.Windows.Forms.RadioButton();
            this.optIn = new System.Windows.Forms.RadioButton();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcEliminado = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.tvMostrar = new System.Windows.Forms.TreeView();
            this.mrcMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigoA)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcMostrar
            // 
            this.mrcMostrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mrcMostrar.Controls.Add(this.optPost);
            this.mrcMostrar.Controls.Add(this.optPre);
            this.mrcMostrar.Controls.Add(this.optIn);
            this.mrcMostrar.Controls.Add(this.dgvMostrar);
            this.mrcMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcMostrar.Location = new System.Drawing.Point(9, 209);
            this.mrcMostrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcMostrar.Name = "mrcMostrar";
            this.mrcMostrar.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcMostrar.Size = new System.Drawing.Size(582, 233);
            this.mrcMostrar.TabIndex = 16;
            this.mrcMostrar.TabStop = false;
            this.mrcMostrar.Text = "Listado del árbol";
            // 
            // optPost
            // 
            this.optPost.AutoSize = true;
            this.optPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPost.Location = new System.Drawing.Point(26, 153);
            this.optPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.optPost.Name = "optPost";
            this.optPost.Size = new System.Drawing.Size(78, 17);
            this.optPost.TabIndex = 4;
            this.optPost.Text = "Post-Orden";
            this.optPost.UseVisualStyleBackColor = true;
            this.optPost.CheckedChanged += new System.EventHandler(this.optPost_CheckedChanged);
            // 
            // optPre
            // 
            this.optPre.AutoSize = true;
            this.optPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPre.Location = new System.Drawing.Point(26, 111);
            this.optPre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.optPre.Name = "optPre";
            this.optPre.Size = new System.Drawing.Size(73, 17);
            this.optPre.TabIndex = 3;
            this.optPre.Text = "Pre-Orden";
            this.optPre.UseVisualStyleBackColor = true;
            this.optPre.CheckedChanged += new System.EventHandler(this.optPre_CheckedChanged);
            // 
            // optIn
            // 
            this.optIn.AutoSize = true;
            this.optIn.Checked = true;
            this.optIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optIn.Location = new System.Drawing.Point(26, 72);
            this.optIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.optIn.Name = "optIn";
            this.optIn.Size = new System.Drawing.Size(66, 17);
            this.optIn.TabIndex = 2;
            this.optIn.TabStop = true;
            this.optIn.Text = "In-Orden";
            this.optIn.UseVisualStyleBackColor = true;
            this.optIn.CheckedChanged += new System.EventHandler(this.optIn_CheckedChanged);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMostrar.Location = new System.Drawing.Point(137, 21);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(431, 198);
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
            // mrcEliminado
            // 
            this.mrcEliminado.BackColor = System.Drawing.Color.IndianRed;
            this.mrcEliminado.Controls.Add(this.btnBuscar);
            this.mrcEliminado.Controls.Add(this.cmbEliminar);
            this.mrcEliminado.Controls.Add(this.btnEliminar);
            this.mrcEliminado.Controls.Add(this.label6);
            this.mrcEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEliminado.Location = new System.Drawing.Point(407, 10);
            this.mrcEliminado.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcEliminado.Size = new System.Drawing.Size(184, 136);
            this.mrcEliminado.TabIndex = 14;
            this.mrcEliminado.TabStop = false;
            this.mrcEliminado.Text = "Eliminar y Buscar Elemento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 98);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 27);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(58, 29);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(113, 21);
            this.cmbEliminar.TabIndex = 6;
            this.cmbEliminar.SelectedIndexChanged += new System.EventHandler(this.cmbEliminar_SelectedIndexChanged);
            this.cmbEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEliminar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 62);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 27);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
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
            this.mrcAgregar.Location = new System.Drawing.Point(210, 9);
            this.mrcAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mrcAgregar.Size = new System.Drawing.Size(184, 182);
            this.mrcAgregar.TabIndex = 13;
            this.mrcAgregar.TabStop = false;
            this.mrcAgregar.Text = "Nuevo Elemento";
            // 
            // updCodigoA
            // 
            this.updCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCodigoA.Location = new System.Drawing.Point(58, 31);
            this.updCodigoA.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.updCodigoA.Name = "updCodigoA";
            this.updCodigoA.Size = new System.Drawing.Size(61, 19);
            this.updCodigoA.TabIndex = 6;
            this.updCodigoA.ValueChanged += new System.EventHandler(this.updCodigoA_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 139);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 27);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteA
            // 
            this.txtTramiteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramiteA.Location = new System.Drawing.Point(58, 103);
            this.txtTramiteA.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTramiteA.Name = "txtTramiteA";
            this.txtTramiteA.Size = new System.Drawing.Size(114, 19);
            this.txtTramiteA.TabIndex = 4;
            this.txtTramiteA.TextChanged += new System.EventHandler(this.txtTramiteA_TextChanged);
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreA.Location = new System.Drawing.Point(58, 66);
            this.txtNombreA.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(114, 19);
            this.txtNombreA.TabIndex = 3;
            this.txtNombreA.TextChanged += new System.EventHandler(this.txtNombreA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEquilibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(407, 148);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(184, 27);
            this.btnEquilibrar.TabIndex = 17;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = false;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // tvMostrar
            // 
            this.tvMostrar.Location = new System.Drawing.Point(9, 9);
            this.tvMostrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tvMostrar.Name = "tvMostrar";
            this.tvMostrar.Size = new System.Drawing.Size(186, 183);
            this.tvMostrar.TabIndex = 18;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 452);
            this.Controls.Add(this.tvMostrar);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mrcMostrar);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura No Lineal - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.mrcMostrar.ResumeLayout(false);
            this.mrcMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
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
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton optPost;
        private System.Windows.Forms.RadioButton optPre;
        private System.Windows.Forms.RadioButton optIn;
        private System.Windows.Forms.TreeView tvMostrar;
        private System.Windows.Forms.Button btnBuscar;
    }
}