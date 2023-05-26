using CapaPresentacion.Utilidades;
using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private DialogResult Autenticar(List<TextBox> campo)
        {
            foreach (TextBox item in campo)
            {
                if (item.Text == "")
                {
                    return MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            agregarFila();
            Limpiar();
            return MessageBox.Show("Usuario creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void agregarFila()
        {
                dgvData.Rows.Add(new object[] { "", IdRegistro.Text, DocumentoRegistro.Text, NombreRegistro.Text, CorreoRegistro.Text,
                ClaveRegistro.Text, ((OpcionCombo)RolRegistro.SelectedItem).Valor.ToString(), ((OpcionCombo)RolRegistro.SelectedItem).Texto.ToString(),
                ((OpcionCombo)EstadoRegistro.SelectedItem).Texto.ToString(), ((OpcionCombo)EstadoRegistro.SelectedItem).Texto.ToString()});
        }

        private void Limpiar()
        {
            IdRegistro.Text = "";
            DocumentoRegistro.Text = "";
            CorreoRegistro.Text = "";
            NombreRegistro.Text = "";
            ClaveRegistro.Text = "";
            ConfirmarClaveRegistro.Text = "";
            RolRegistro.SelectedItem = 0;
            EstadoRegistro.SelectedItem = 0;
        }

    private void btnGuardarRegistro_Click(object sender, EventArgs e)
    {
            List<TextBox> listaTextBox = new List<TextBox>() { DocumentoRegistro, NombreRegistro, CorreoRegistro, ClaveRegistro, ConfirmarClaveRegistro };
            Autenticar(listaTextBox);
    } 

        private void frmUsuario_Load(object sender, EventArgs e)
        {   
            
            EstadoRegistro.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            EstadoRegistro.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });

            EstadoRegistro.DisplayMember = "Texto";
            EstadoRegistro.ValueMember = "Valor";
            EstadoRegistro.SelectedIndex = 0;

            List<Rol> listaRol = new CN_ROL().Listar();

            foreach (Rol item in listaRol)
            {
                RolRegistro.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion});   
            } 
            RolRegistro.DisplayMember = "Texto";
            RolRegistro.ValueMember = "Valor";
            RolRegistro.SelectedIndex = 0;  

            foreach(DataGridViewColumn column in dgvData.Columns)
            {
                if (column.Visible && column.Name != "btnSeleccionar")
                {
                    filtrarRegistro.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }

            filtrarRegistro.DisplayMember = "Texto";
            filtrarRegistro.ValueMember = "Valor";
            filtrarRegistro.SelectedIndex = 0;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RolRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
