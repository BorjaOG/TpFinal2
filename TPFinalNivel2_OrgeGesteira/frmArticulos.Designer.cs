namespace Service
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminarf = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.tbfiltro = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.lblfilter = new System.Windows.Forms.Label();
            this.cbcriterio = new System.Windows.Forms.ComboBox();
            this.cbcampo = new System.Windows.Forms.ComboBox();
            this.tbfilter = new System.Windows.Forms.TextBox();
            this.btndetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 79);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(643, 276);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(678, 79);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(281, 276);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(24, 379);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(92, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(122, 379);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 23);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminarf
            // 
            this.btneliminarf.Location = new System.Drawing.Point(215, 379);
            this.btneliminarf.Name = "btneliminarf";
            this.btneliminarf.Size = new System.Drawing.Size(84, 23);
            this.btneliminarf.TabIndex = 4;
            this.btneliminarf.Text = "Eliminar ";
            this.btneliminarf.UseVisualStyleBackColor = true;
            this.btneliminarf.Click += new System.EventHandler(this.btneliminarf_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(13, 47);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(66, 13);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtro Rapido";
            // 
            // tbfiltro
            // 
            this.tbfiltro.Location = new System.Drawing.Point(101, 44);
            this.tbfiltro.Name = "tbfiltro";
            this.tbfiltro.Size = new System.Drawing.Size(222, 20);
            this.tbfiltro.TabIndex = 7;
            this.tbfiltro.TextChanged += new System.EventHandler(this.tbfiltro_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(624, 443);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(104, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(21, 453);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(40, 13);
            this.lblcampo.TabIndex = 9;
            this.lblcampo.Text = "Campo";
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(229, 453);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(39, 13);
            this.lblcriterio.TabIndex = 10;
            this.lblcriterio.Text = "Criterio";
            // 
            // lblfilter
            // 
            this.lblfilter.AutoSize = true;
            this.lblfilter.Location = new System.Drawing.Point(437, 453);
            this.lblfilter.Name = "lblfilter";
            this.lblfilter.Size = new System.Drawing.Size(29, 13);
            this.lblfilter.TabIndex = 11;
            this.lblfilter.Text = "Filtro";
            // 
            // cbcriterio
            // 
            this.cbcriterio.FormattingEnabled = true;
            this.cbcriterio.Location = new System.Drawing.Point(290, 445);
            this.cbcriterio.Name = "cbcriterio";
            this.cbcriterio.Size = new System.Drawing.Size(121, 21);
            this.cbcriterio.TabIndex = 12;
            // 
            // cbcampo
            // 
            this.cbcampo.FormattingEnabled = true;
            this.cbcampo.Location = new System.Drawing.Point(82, 445);
            this.cbcampo.Name = "cbcampo";
            this.cbcampo.Size = new System.Drawing.Size(121, 21);
            this.cbcampo.TabIndex = 13;
            this.cbcampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // tbfilter
            // 
            this.tbfilter.Location = new System.Drawing.Point(498, 446);
            this.tbfilter.Name = "tbfilter";
            this.tbfilter.Size = new System.Drawing.Size(100, 20);
            this.tbfilter.TabIndex = 14;
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(433, 379);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(222, 23);
            this.btndetalle.TabIndex = 15;
            this.btndetalle.Text = "Ver Detalles";
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 492);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.tbfilter);
            this.Controls.Add(this.cbcampo);
            this.Controls.Add(this.cbcriterio);
            this.Controls.Add(this.lblfilter);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.btneliminarf);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminarf;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox tbfiltro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label lblfilter;
        private System.Windows.Forms.ComboBox cbcriterio;
        private System.Windows.Forms.ComboBox cbcampo;
        private System.Windows.Forms.TextBox tbfilter;
        private System.Windows.Forms.Button btndetalle;
    }
}

