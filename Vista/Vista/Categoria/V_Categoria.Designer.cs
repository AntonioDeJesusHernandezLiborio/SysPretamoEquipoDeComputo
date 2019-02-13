namespace Vista.Categoria
{
    partial class V_Categoria
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwDatosCategoria = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatosCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(348, 153);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(109, 34);
            this.BtnCancelar.TabIndex = 22;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(15, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(243, 29);
            this.txtCodigo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Codigo";
            // 
            // dgwDatosCategoria
            // 
            this.dgwDatosCategoria.AllowDrop = true;
            this.dgwDatosCategoria.AllowUserToAddRows = false;
            this.dgwDatosCategoria.AllowUserToDeleteRows = false;
            this.dgwDatosCategoria.AllowUserToOrderColumns = true;
            this.dgwDatosCategoria.AllowUserToResizeColumns = false;
            this.dgwDatosCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgwDatosCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwDatosCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgwDatosCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwDatosCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatosCategoria.Location = new System.Drawing.Point(13, 228);
            this.dgwDatosCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwDatosCategoria.Name = "dgwDatosCategoria";
            this.dgwDatosCategoria.ReadOnly = true;
            this.dgwDatosCategoria.Size = new System.Drawing.Size(1223, 312);
            this.dgwDatosCategoria.TabIndex = 19;
            this.dgwDatosCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDatosCategoria_CellContentClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.Location = new System.Drawing.Point(628, 153);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 34);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Enabled = false;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.Location = new System.Drawing.Point(482, 153);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(109, 34);
            this.BtnEditar.TabIndex = 17;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnAgregar.Location = new System.Drawing.Point(348, 153);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(109, 34);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(441, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista de Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.Location = new System.Drawing.Point(13, 106);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(665, 29);
            this.txtDescripcion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion de categoria:";
            // 
            // V_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 552);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwDatosCategoria);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "V_Categoria";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatosCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwDatosCategoria;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
    }
}