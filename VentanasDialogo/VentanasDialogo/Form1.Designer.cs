namespace VentanasDialogo
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
            this.label = new System.Windows.Forms.Label();
            this.Caja = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.RadioButton();
            this.folder = new System.Windows.Forms.RadioButton();
            this.color = new System.Windows.Forms.RadioButton();
            this.font = new System.Windows.Forms.RadioButton();
            this.Abrir = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
           
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(167, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 1;
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Caja
            // 
            this.Caja.Location = new System.Drawing.Point(124, 74);
            this.Caja.Multiline = true;
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(218, 20);
            this.Caja.TabIndex = 2;
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Location = new System.Drawing.Point(46, 19);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(97, 17);
            this.Open.TabIndex = 3;
            this.Open.TabStop = true;
            this.Open.Text = "OpenFileDialog";
            this.Open.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.Location = new System.Drawing.Point(47, 66);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(96, 17);
            this.save.TabIndex = 4;
            this.save.TabStop = true;
            this.save.Text = "SaveFileDialog";
            this.save.UseVisualStyleBackColor = true;
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.Location = new System.Drawing.Point(46, 114);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(122, 17);
            this.folder.TabIndex = 5;
            this.folder.TabStop = true;
            this.folder.Text = "FolderBrowserDialog";
            this.folder.UseVisualStyleBackColor = true;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(47, 162);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(79, 17);
            this.color.TabIndex = 6;
            this.color.TabStop = true;
            this.color.Text = "ColorDialog";
            this.color.UseVisualStyleBackColor = true;
            // 
            // font
            // 
            this.font.AutoSize = true;
            this.font.Location = new System.Drawing.Point(52, 213);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(76, 17);
            this.font.TabIndex = 7;
            this.font.TabStop = true;
            this.font.Text = "FontDialog";
            this.font.UseVisualStyleBackColor = true;
            // 
            // Abrir
            // 
            this.Abrir.Location = new System.Drawing.Point(408, 172);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(132, 54);
            this.Abrir.TabIndex = 8;
            this.Abrir.Text = "Abrir";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(408, 264);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(132, 62);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Open);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.folder);
            this.groupBox1.Controls.Add(this.font);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Location = new System.Drawing.Point(124, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 252);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
       
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Caja;
        private System.Windows.Forms.RadioButton Open;
        private System.Windows.Forms.RadioButton save;
        private System.Windows.Forms.RadioButton folder;
        private System.Windows.Forms.RadioButton color;
        private System.Windows.Forms.RadioButton font;
        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
       
        private System.Windows.Forms.TextBox textBox1;
    }
}

