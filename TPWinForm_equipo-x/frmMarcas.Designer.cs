namespace TPWinForm_equipo_11B
{
    partial class frmMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.txtMarcaNueva = new System.Windows.Forms.TextBox();
            this.btnMarcaNueva = new System.Windows.Forms.Button();
            this.btnMarcaModificarAceptar = new System.Windows.Forms.Button();
            this.txtMarcaModificar = new System.Windows.Forms.TextBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.btnVolverMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(68, 85);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(199, 306);
            this.dgvMarcas.TabIndex = 0;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(328, 85);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(125, 51);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(328, 340);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(125, 51);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(328, 212);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(125, 51);
            this.btnModificarMarca.TabIndex = 3;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // txtMarcaNueva
            // 
            this.txtMarcaNueva.Location = new System.Drawing.Point(328, 142);
            this.txtMarcaNueva.Name = "txtMarcaNueva";
            this.txtMarcaNueva.Size = new System.Drawing.Size(125, 20);
            this.txtMarcaNueva.TabIndex = 4;
            this.txtMarcaNueva.Visible = false;
            // 
            // btnMarcaNueva
            // 
            this.btnMarcaNueva.Location = new System.Drawing.Point(349, 168);
            this.btnMarcaNueva.Name = "btnMarcaNueva";
            this.btnMarcaNueva.Size = new System.Drawing.Size(75, 23);
            this.btnMarcaNueva.TabIndex = 5;
            this.btnMarcaNueva.Text = "Aceptar";
            this.btnMarcaNueva.UseVisualStyleBackColor = true;
            this.btnMarcaNueva.Visible = false;
            this.btnMarcaNueva.Click += new System.EventHandler(this.btnMarcaNueva_Click);
            // 
            // btnMarcaModificarAceptar
            // 
            this.btnMarcaModificarAceptar.Location = new System.Drawing.Point(349, 295);
            this.btnMarcaModificarAceptar.Name = "btnMarcaModificarAceptar";
            this.btnMarcaModificarAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcaModificarAceptar.TabIndex = 7;
            this.btnMarcaModificarAceptar.Text = "Aceptar";
            this.btnMarcaModificarAceptar.UseVisualStyleBackColor = true;
            this.btnMarcaModificarAceptar.Visible = false;
            this.btnMarcaModificarAceptar.Click += new System.EventHandler(this.btnMarcaModificarAceptar_Click);
            // 
            // txtMarcaModificar
            // 
            this.txtMarcaModificar.Location = new System.Drawing.Point(328, 269);
            this.txtMarcaModificar.Name = "txtMarcaModificar";
            this.txtMarcaModificar.Size = new System.Drawing.Size(125, 20);
            this.txtMarcaModificar.TabIndex = 6;
            this.txtMarcaModificar.Visible = false;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.Black;
            this.lblMarcas.Location = new System.Drawing.Point(-4, 26);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Padding = new System.Windows.Forms.Padding(100, 0, 350, 0);
            this.lblMarcas.Size = new System.Drawing.Size(580, 31);
            this.lblMarcas.TabIndex = 8;
            this.lblMarcas.Text = "MARCAS";
            // 
            // btnVolverMarcas
            // 
            this.btnVolverMarcas.Location = new System.Drawing.Point(349, 415);
            this.btnVolverMarcas.Name = "btnVolverMarcas";
            this.btnVolverMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMarcas.TabIndex = 9;
            this.btnVolverMarcas.Text = "Volver";
            this.btnVolverMarcas.UseVisualStyleBackColor = true;
            this.btnVolverMarcas.Click += new System.EventHandler(this.btnVolverMarcas_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 459);
            this.Controls.Add(this.btnVolverMarcas);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.btnMarcaModificarAceptar);
            this.Controls.Add(this.txtMarcaModificar);
            this.Controls.Add(this.btnMarcaNueva);
            this.Controls.Add(this.txtMarcaNueva);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.MaximumSize = new System.Drawing.Size(547, 498);
            this.MinimumSize = new System.Drawing.Size(547, 498);
            this.Name = "frmMarcas";
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.TextBox txtMarcaNueva;
        private System.Windows.Forms.Button btnMarcaNueva;
        private System.Windows.Forms.Button btnMarcaModificarAceptar;
        private System.Windows.Forms.TextBox txtMarcaModificar;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Button btnVolverMarcas;
    }
}