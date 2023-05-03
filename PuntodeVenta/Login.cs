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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            form.FormClosing += frm_clossing;
        }

        private void frm_clossing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            this.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
