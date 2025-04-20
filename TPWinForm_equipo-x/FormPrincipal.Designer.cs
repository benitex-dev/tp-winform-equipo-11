namespace TPWinForm_equipo_11
{
    partial class VentanaPrincipal
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
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.labelCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogo.Location = new System.Drawing.Point(181, 119);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(493, 394);
            this.dgvCatalogo.TabIndex = 0;
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxImagen.Location = new System.Drawing.Point(714, 98);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(228, 232);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(35, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 52);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(35, 413);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 50);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDetalle.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(714, 336);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(228, 62);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFiltro.Location = new System.Drawing.Point(31, 119);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(80, 20);
            this.labelFiltro.TabIndex = 6;
            this.labelFiltro.Text = "Filtrar por:";
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(34, 233);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriterio.TabIndex = 7;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(34, 178);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 8;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFiltro.Location = new System.Drawing.Point(181, 84);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(249, 20);
            this.textBoxFiltro.TabIndex = 9;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(452, 84);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(35, 469);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 44);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(35, 260);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(121, 42);
            this.btnFiltro.TabIndex = 13;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            // 
            // labelCatalogo
            // 
            this.labelCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCatalogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelCatalogo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogo.Location = new System.Drawing.Point(1, 1);
            this.labelCatalogo.Name = "labelCatalogo";
            this.labelCatalogo.Size = new System.Drawing.Size(967, 60);
            this.labelCatalogo.TabIndex = 14;
            this.labelCatalogo.Text = "CATALOGO";
            this.labelCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Campo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(31, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Criterio";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(970, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCatalogo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.dgvCatalogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(986, 592);
            this.MinimumSize = new System.Drawing.Size(986, 592);
            this.Name = "VentanaPrincipal";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label labelCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}