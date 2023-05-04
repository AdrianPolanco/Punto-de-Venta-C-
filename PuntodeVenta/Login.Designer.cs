﻿namespace PuntodeVenta
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonIngresar = new FontAwesome.Sharp.IconButton();
            this.botonCancelar = new FontAwesome.Sharp.IconButton();
            this.botonLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 335);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "FastSale";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hotjar;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 159;
            this.iconPictureBox1.Location = new System.Drawing.Point(52, 97);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(186, 159);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(376, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(376, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(350, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(372, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario/Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(372, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.botonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIngresar.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.botonIngresar.ForeColor = System.Drawing.Color.White;
            this.botonIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.botonIngresar.IconColor = System.Drawing.Color.White;
            this.botonIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonIngresar.IconSize = 35;
            this.botonIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonIngresar.Location = new System.Drawing.Point(376, 250);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Padding = new System.Windows.Forms.Padding(3);
            this.botonIngresar.Size = new System.Drawing.Size(150, 49);
            this.botonIngresar.TabIndex = 9;
            this.botonIngresar.Text = "    Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = false;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelar.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.Color.White;
            this.botonCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.botonCancelar.IconColor = System.Drawing.Color.White;
            this.botonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonCancelar.IconSize = 30;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.botonCancelar.Location = new System.Drawing.Point(576, 250);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Padding = new System.Windows.Forms.Padding(3);
            this.botonCancelar.Size = new System.Drawing.Size(150, 49);
            this.botonCancelar.TabIndex = 10;
            this.botonCancelar.Text = "   Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.PaleGreen;
            this.botonLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.botonLimpiar.IconColor = System.Drawing.Color.Beige;
            this.botonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonLimpiar.IconSize = 14;
            this.botonLimpiar.Location = new System.Drawing.Point(732, 185);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 24);
            this.botonLimpiar.TabIndex = 11;
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 335);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton botonIngresar;
        private FontAwesome.Sharp.IconButton botonCancelar;
        private FontAwesome.Sharp.IconButton botonLimpiar;
    }
}

