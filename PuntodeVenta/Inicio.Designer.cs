﻿namespace PuntodeVenta
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconoUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconoMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconoVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconoCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconoClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iconoProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconoReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconoAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconoUsuario,
            this.iconoMantenedor,
            this.iconoVentas,
            this.iconoCompras,
            this.iconoClientes,
            this.iconoProveedores,
            this.iconoReportes,
            this.iconoAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 54);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 78);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // iconoUsuario
            // 
            this.iconoUsuario.AutoSize = false;
            this.iconoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconoUsuario.IconColor = System.Drawing.Color.Black;
            this.iconoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoUsuario.IconSize = 50;
            this.iconoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoUsuario.Name = "iconoUsuario";
            this.iconoUsuario.Size = new System.Drawing.Size(80, 74);
            this.iconoUsuario.Text = "Usuarios";
            this.iconoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoMantenedor
            // 
            this.iconoMantenedor.AutoSize = false;
            this.iconoMantenedor.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconoMantenedor.IconColor = System.Drawing.Color.Black;
            this.iconoMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoMantenedor.IconSize = 50;
            this.iconoMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoMantenedor.Name = "iconoMantenedor";
            this.iconoMantenedor.Size = new System.Drawing.Size(103, 74);
            this.iconoMantenedor.Text = "Mantenedor";
            this.iconoMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoVentas
            // 
            this.iconoVentas.AutoSize = false;
            this.iconoVentas.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconoVentas.IconColor = System.Drawing.Color.Black;
            this.iconoVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoVentas.IconSize = 50;
            this.iconoVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoVentas.Name = "iconoVentas";
            this.iconoVentas.Size = new System.Drawing.Size(80, 74);
            this.iconoVentas.Text = "Ventas";
            this.iconoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoCompras
            // 
            this.iconoCompras.AutoSize = false;
            this.iconoCompras.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoCompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.iconoCompras.IconColor = System.Drawing.Color.Black;
            this.iconoCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoCompras.IconSize = 50;
            this.iconoCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoCompras.Name = "iconoCompras";
            this.iconoCompras.Size = new System.Drawing.Size(80, 74);
            this.iconoCompras.Text = "Compras";
            this.iconoCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoClientes
            // 
            this.iconoClientes.AutoSize = false;
            this.iconoClientes.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconoClientes.IconColor = System.Drawing.Color.Black;
            this.iconoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoClientes.IconSize = 50;
            this.iconoClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoClientes.Name = "iconoClientes";
            this.iconoClientes.Size = new System.Drawing.Size(80, 74);
            this.iconoClientes.Text = "Clientes";
            this.iconoClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoProveedores
            // 
            this.iconoProveedores.AutoSize = false;
            this.iconoProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconoProveedores.IconColor = System.Drawing.Color.Black;
            this.iconoProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoProveedores.IconSize = 50;
            this.iconoProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoProveedores.Name = "iconoProveedores";
            this.iconoProveedores.Size = new System.Drawing.Size(105, 74);
            this.iconoProveedores.Text = "Proveedores";
            this.iconoProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoReportes
            // 
            this.iconoReportes.AutoSize = false;
            this.iconoReportes.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoReportes.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconoReportes.IconColor = System.Drawing.Color.Black;
            this.iconoReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoReportes.IconSize = 50;
            this.iconoReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoReportes.Name = "iconoReportes";
            this.iconoReportes.Size = new System.Drawing.Size(80, 74);
            this.iconoReportes.Text = "Reportes";
            this.iconoReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconoAcercaDe
            // 
            this.iconoAcercaDe.AutoSize = false;
            this.iconoAcercaDe.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iconoAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconoAcercaDe.IconColor = System.Drawing.Color.Black;
            this.iconoAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoAcercaDe.IconSize = 50;
            this.iconoAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconoAcercaDe.Name = "iconoAcercaDe";
            this.iconoAcercaDe.Size = new System.Drawing.Size(95, 74);
            this.iconoAcercaDe.Text = "Acerca De";
            this.iconoAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.PaleGreen;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(800, 54);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.nameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(1, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(155, 49);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "FastSale";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 132);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(800, 318);
            this.Contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label nameLabel;
        private FontAwesome.Sharp.IconMenuItem iconoAcercaDe;
        private FontAwesome.Sharp.IconMenuItem iconoUsuario;
        private FontAwesome.Sharp.IconMenuItem iconoMantenedor;
        private FontAwesome.Sharp.IconMenuItem iconoVentas;
        private FontAwesome.Sharp.IconMenuItem iconoCompras;
        private FontAwesome.Sharp.IconMenuItem iconoProveedores;
        private FontAwesome.Sharp.IconMenuItem iconoClientes;
        private FontAwesome.Sharp.IconMenuItem iconoReportes;
        private System.Windows.Forms.Panel Contenedor;
    }
}