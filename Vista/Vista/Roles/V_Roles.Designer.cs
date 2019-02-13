namespace Vista.Roles
{
    partial class V_Roles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dgwDatosRoles = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatosRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion de rol:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.Location = new System.Drawing.Point(12, 99);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(416, 29);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(157, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de roles";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnAgregar.Location = new System.Drawing.Point(11, 146);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(109, 34);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Enabled = false;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.Location = new System.Drawing.Point(145, 146);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(109, 34);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.Location = new System.Drawing.Point(291, 146);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 34);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dgwDatosRoles
            // 
            this.dgwDatosRoles.AllowDrop = true;
            this.dgwDatosRoles.AllowUserToAddRows = false;
            this.dgwDatosRoles.AllowUserToDeleteRows = false;
            this.dgwDatosRoles.AllowUserToOrderColumns = true;
            this.dgwDatosRoles.AllowUserToResizeColumns = false;
            this.dgwDatosRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgwDatosRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwDatosRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgwDatosRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwDatosRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatosRoles.Location = new System.Drawing.Point(12, 221);
            this.dgwDatosRoles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwDatosRoles.Name = "dgwDatosRoles";
            this.dgwDatosRoles.ReadOnly = true;
            this.dgwDatosRoles.Size = new System.Drawing.Size(416, 186);
            this.dgwDatosRoles.TabIndex = 9;
            this.dgwDatosRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDatosRoles_CellContentClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(14, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 29);
            this.txtCodigo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(11, 146);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(109, 34);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // V_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 419);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwDatosRoles);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "V_Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatosRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dgwDatosRoles;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
    }
}