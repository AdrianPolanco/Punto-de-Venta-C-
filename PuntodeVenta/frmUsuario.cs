using CapaPresentacion.Utilidades;
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

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {   RolRegistro.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Usuario" });
            RolRegistro.Items.Add(new OpcionCombo() {Valor = 1, Texto="Administrador" });

            RolRegistro.DisplayMember = "Texto";
            RolRegistro.ValueMember = "Valor";
            RolRegistro.SelectedIndex = 0;
            
            EstadoRegistro.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            EstadoRegistro.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });

            EstadoRegistro.DisplayMember = "Texto";
            EstadoRegistro.ValueMember = "Valor";
            EstadoRegistro.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
