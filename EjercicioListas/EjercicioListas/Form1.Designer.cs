namespace EjercicioListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.Añadir = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.RadioButton();
            this.boton2 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introducir usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduir clave";
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(196, 60);
            this.clave.Multiline = true;
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(100, 20);
            this.clave.TabIndex = 2;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(522, 60);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 3;
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(186, 102);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(75, 23);
            this.Añadir.TabIndex = 4;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(355, 102);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 5;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(522, 102);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(355, 319);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // boton1
            // 
            this.boton1.AutoSize = true;
            this.boton1.Location = new System.Drawing.Point(208, 156);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(53, 17);
            this.boton1.TabIndex = 8;
            this.boton1.TabStop = true;
            this.boton1.Text = "Lista1";
            this.boton1.UseVisualStyleBackColor = true;
            // 
            // boton2
            // 
            this.boton2.AutoSize = true;
            this.boton2.Location = new System.Drawing.Point(510, 156);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(53, 17);
            this.boton2.TabIndex = 9;
            this.boton2.TabStop = true;
            this.boton2.Text = "Lista2";
            this.boton2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(167, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(146, 110);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(498, 175);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(148, 110);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.RadioButton boton1;
        private System.Windows.Forms.RadioButton boton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}

