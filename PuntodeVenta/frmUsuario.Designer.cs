namespace PuntodeVenta
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocumentoRegistro = new System.Windows.Forms.TextBox();
            this.NombreRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClaveRegistro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmarClaveRegistro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RolRegistro = new System.Windows.Forms.ComboBox();
            this.EstadoRegistro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnEditarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dB_PUNTO_VENTADataSet = new PuntodeVenta.DB_PUNTO_VENTADataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new PuntodeVenta.DB_PUNTO_VENTADataSetTableAdapters.USUARIOTableAdapter();
            this.dBPUNTOVENTADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PUNTO_VENTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPUNTOVENTADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 641);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. de Documento:";
            // 
            // DocumentoRegistro
            // 
            this.DocumentoRegistro.Location = new System.Drawing.Point(34, 93);
            this.DocumentoRegistro.Name = "DocumentoRegistro";
            this.DocumentoRegistro.Size = new System.Drawing.Size(234, 22);
            this.DocumentoRegistro.TabIndex = 2;
            // 
            // NombreRegistro
            // 
            this.NombreRegistro.Location = new System.Drawing.Point(34, 154);
            this.NombreRegistro.Name = "NombreRegistro";
            this.NombreRegistro.Size = new System.Drawing.Size(234, 22);
            this.NombreRegistro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // CorreoRegistro
            // 
            this.CorreoRegistro.Location = new System.Drawing.Point(34, 207);
            this.CorreoRegistro.Name = "CorreoRegistro";
            this.CorreoRegistro.Size = new System.Drawing.Size(234, 22);
            this.CorreoRegistro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo:";
            // 
            // ClaveRegistro
            // 
            this.ClaveRegistro.Location = new System.Drawing.Point(34, 262);
            this.ClaveRegistro.Name = "ClaveRegistro";
            this.ClaveRegistro.Size = new System.Drawing.Size(234, 22);
            this.ClaveRegistro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // ConfirmarClaveRegistro
            // 
            this.ConfirmarClaveRegistro.Location = new System.Drawing.Point(34, 317);
            this.ConfirmarClaveRegistro.Name = "ConfirmarClaveRegistro";
            this.ConfirmarClaveRegistro.Size = new System.Drawing.Size(234, 22);
            this.ConfirmarClaveRegistro.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmar contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rol:";
            // 
            // RolRegistro
            // 
            this.RolRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolRegistro.FormattingEnabled = true;
            this.RolRegistro.Location = new System.Drawing.Point(34, 376);
            this.RolRegistro.Name = "RolRegistro";
            this.RolRegistro.Size = new System.Drawing.Size(234, 24);
            this.RolRegistro.TabIndex = 12;
            this.RolRegistro.SelectedIndexChanged += new System.EventHandler(this.RolRegistro_SelectedIndexChanged);
            // 
            // EstadoRegistro
            // 
            this.EstadoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoRegistro.FormattingEnabled = true;
            this.EstadoRegistro.Location = new System.Drawing.Point(34, 432);
            this.EstadoRegistro.Name = "EstadoRegistro";
            this.EstadoRegistro.Size = new System.Drawing.Size(234, 24);
            this.EstadoRegistro.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado:";
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardarRegistro.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRegistro.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarRegistro.IconColor = System.Drawing.Color.White;
            this.btnGuardarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarRegistro.IconSize = 24;
            this.btnGuardarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRegistro.Location = new System.Drawing.Point(72, 475);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.btnGuardarRegistro.Size = new System.Drawing.Size(131, 40);
            this.btnGuardarRegistro.TabIndex = 20;
            this.btnGuardarRegistro.Text = "Guardar";
            this.btnGuardarRegistro.UseVisualStyleBackColor = false;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnEditarRegistro
            // 
            this.btnEditarRegistro.BackColor = System.Drawing.Color.Gold;
            this.btnEditarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnEditarRegistro.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEditarRegistro.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarRegistro.IconColor = System.Drawing.Color.White;
            this.btnEditarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarRegistro.IconSize = 24;
            this.btnEditarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarRegistro.Location = new System.Drawing.Point(72, 521);
            this.btnEditarRegistro.Name = "btnEditarRegistro";
            this.btnEditarRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.btnEditarRegistro.Size = new System.Drawing.Size(131, 40);
            this.btnEditarRegistro.TabIndex = 21;
            this.btnEditarRegistro.Text = "Editar";
            this.btnEditarRegistro.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarRegistro.IconColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRegistro.IconSize = 24;
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(72, 567);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.btnEliminarRegistro.Size = new System.Drawing.Size(131, 39);
            this.btnEliminarRegistro.TabIndex = 22;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 60);
            this.label9.TabIndex = 23;
            this.label9.Text = "Administración de \r\nusuarios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(343, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(406, 72);
            this.label10.TabIndex = 25;
            this.label10.Text = "Lista de usuarios";
            // 
            // dB_PUNTO_VENTADataSet
            // 
            this.dB_PUNTO_VENTADataSet.DataSetName = "DB_PUNTO_VENTADataSet";
            this.dB_PUNTO_VENTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.dB_PUNTO_VENTADataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // dBPUNTOVENTADataSetBindingSource
            // 
            this.dBPUNTOVENTADataSetBindingSource.DataSource = this.dB_PUNTO_VENTADataSet;
            this.dBPUNTOVENTADataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdUsuario,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.Estado,
            this.EstadoValor});
            this.dataGridView1.Location = new System.Drawing.Point(336, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(832, 457);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 50;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 30;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "No. de Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            this.Clave.Width = 125;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1061, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(83, 22);
            this.txtId.TabIndex = 27;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(952, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Buscar ID:";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1167, 641);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.btnEditarRegistro);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.EstadoRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RolRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ConfirmarClaveRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClaveRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreoRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocumentoRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PUNTO_VENTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPUNTOVENTADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocumentoRegistro;
        private System.Windows.Forms.TextBox NombreRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreoRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClaveRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConfirmarClaveRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RolRegistro;
        private System.Windows.Forms.ComboBox EstadoRegistro;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnGuardarRegistro;
        private FontAwesome.Sharp.IconButton btnEditarRegistro;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DB_PUNTO_VENTADataSet dB_PUNTO_VENTADataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private DB_PUNTO_VENTADataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.BindingSource dBPUNTOVENTADataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
    }
}