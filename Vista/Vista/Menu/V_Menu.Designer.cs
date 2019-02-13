namespace Vista.Menu
{
    partial class V_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Menu));
            this.BtnRoles = new System.Windows.Forms.Button();
            this.BtnCategoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRoles
            // 
            this.BtnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnRoles.Location = new System.Drawing.Point(39, 42);
            this.BtnRoles.Name = "BtnRoles";
            this.BtnRoles.Size = new System.Drawing.Size(192, 90);
            this.BtnRoles.TabIndex = 0;
            this.BtnRoles.Text = "ROLES";
            this.BtnRoles.UseVisualStyleBackColor = true;
            this.BtnRoles.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // BtnCategoria
            // 
            this.BtnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnCategoria.Location = new System.Drawing.Point(39, 296);
            this.BtnCategoria.Name = "BtnCategoria";
            this.BtnCategoria.Size = new System.Drawing.Size(192, 90);
            this.BtnCategoria.TabIndex = 1;
            this.BtnCategoria.Text = "CATEGORIA";
            this.BtnCategoria.UseVisualStyleBackColor = true;
            this.BtnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // V_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCategoria);
            this.Controls.Add(this.BtnRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRoles;
        private System.Windows.Forms.Button BtnCategoria;
        private System.Windows.Forms.Button button1;
    }
}