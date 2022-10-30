namespace Ejercicio_4
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.Contraseñalabel = new System.Windows.Forms.Label();
            this.Correolabel = new System.Windows.Forms.Label();
            this.ContraseniaTextBox = new System.Windows.Forms.TextBox();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolabel.Location = new System.Drawing.Point(192, 23);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(68, 20);
            this.Usuariolabel.TabIndex = 0;
            this.Usuariolabel.Text = "Usuario";
            // 
            // Contraseñalabel
            // 
            this.Contraseñalabel.AutoSize = true;
            this.Contraseñalabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñalabel.Location = new System.Drawing.Point(25, 113);
            this.Contraseñalabel.Name = "Contraseñalabel";
            this.Contraseñalabel.Size = new System.Drawing.Size(105, 19);
            this.Contraseñalabel.TabIndex = 1;
            this.Contraseñalabel.Text = "Contraseña:";
            // 
            // Correolabel
            // 
            this.Correolabel.AutoSize = true;
            this.Correolabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correolabel.Location = new System.Drawing.Point(49, 69);
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(69, 19);
            this.Correolabel.TabIndex = 2;
            this.Correolabel.Text = "Correo:";
            // 
            // ContraseniaTextBox
            // 
            this.ContraseniaTextBox.Location = new System.Drawing.Point(137, 110);
            this.ContraseniaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContraseniaTextBox.Name = "ContraseniaTextBox";
            this.ContraseniaTextBox.PasswordChar = '*';
            this.ContraseniaTextBox.Size = new System.Drawing.Size(195, 22);
            this.ContraseniaTextBox.TabIndex = 7;
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(137, 66);
            this.CorreoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(195, 22);
            this.CorreoTextBox.TabIndex = 6;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Image = global::Ejercicio_4.Properties.Resources.cancelar;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(232, 180);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(100, 40);
            this.CancelarButton.TabIndex = 9;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Image = global::Ejercicio_4.Properties.Resources.aceptar;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.Location = new System.Drawing.Point(102, 180);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(104, 40);
            this.AceptarButton.TabIndex = 8;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio_4.Properties.Resources.usuario__2_;
            this.pictureBox1.Location = new System.Drawing.Point(373, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.ContraseniaTextBox);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.Correolabel);
            this.Controls.Add(this.Contraseñalabel);
            this.Controls.Add(this.Usuariolabel);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.Label Contraseñalabel;
        private System.Windows.Forms.Label Correolabel;
        private System.Windows.Forms.TextBox ContraseniaTextBox;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

