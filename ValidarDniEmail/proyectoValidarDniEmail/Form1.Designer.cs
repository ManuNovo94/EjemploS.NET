namespace proyectoValidarDniEmail
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cajaEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cajaDni = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaEmail
            // 
            this.cajaEmail.Location = new System.Drawing.Point(106, 115);
            this.cajaEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cajaEmail.Name = "cajaEmail";
            this.cajaEmail.Size = new System.Drawing.Size(76, 20);
            this.cajaEmail.TabIndex = 0;
            this.cajaEmail.TextChanged += new System.EventHandler(this.cajaEmail_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(95, 171);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(97, 22);
            this.email.TabIndex = 1;
            this.email.Text = "Validar Email";
            this.email.UseVisualStyleBackColor = true;
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 144);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(6, 6);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cajaDni
            // 
            this.cajaDni.Location = new System.Drawing.Point(290, 115);
            this.cajaDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cajaDni.Name = "cajaDni";
            this.cajaDni.Size = new System.Drawing.Size(76, 20);
            this.cajaDni.TabIndex = 3;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(281, 171);
            this.dni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(95, 22);
            this.dni.TabIndex = 4;
            this.dni.Text = "Validar DNI";
            this.dni.UseVisualStyleBackColor = true;
            this.dni.Click += new System.EventHandler(this.dni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.cajaDni);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cajaEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaEmail;
        private System.Windows.Forms.Button email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cajaDni;
        private System.Windows.Forms.Button dni;
    }
}

