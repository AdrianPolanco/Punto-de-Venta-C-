using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace PuntodeVenta
{
    public partial class Inicio : Form
    {
        private Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            if(objusuario == null) {
                usuarioActual = new Usuario() { NombreCompleto = "Admin Default", IdUsuario = 1 };
            }
            else
            {
                usuarioActual = objusuario;
            }
            InitializeComponent();

            
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menutitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permisos> ListaPermisos = new CN_PERMISOS().Listar(usuarioActual.IdUsuario);
            foreach(IconMenuItem icon in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == icon.Name);

                if (!encontrado)
                {
                    icon.Visible = false;
                }
            }
            lblUsuario.Text = usuarioActual.NombreCompleto;

        }

        private void abrirForm(IconMenuItem menu, Form formulario)
        {
            if(MenuActivo != null) {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
          
            formulario.BackColor = Color.PaleGreen;

            this.AutoSize = true;
            Contenedor.AutoSize = true;
            Contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void iconoUsuario_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem) sender, new frmUsuario());
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(iconoMantenedor, new frmProductos());
        }

        private void SubMenuCategorias_Click(object sender, EventArgs e)
        {
            abrirForm(iconoMantenedor, new frmCategorias());
        }

        private void iconoVentas_Click(object sender, EventArgs e)
        {

        }

        private void iconoCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void iconoProveedores_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem)sender, new frmProveedores());
        }

        private void SubMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirForm(iconoVentas, new frmVentas());
        }

        private void SubMenuRegistrarCompras_Click(object sender, EventArgs e)
        {
            abrirForm(iconoCompras, new frmCompras());
        }

        private void SubMenuVerDetalleCompras_Click(object sender, EventArgs e)
        {
            abrirForm(iconoCompras, new frmDetalleCompras());
        }

        private void SubMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirForm(iconoVentas, new frmDetalleVenta());
        }

        private void iconoClientes_Click(object sender, EventArgs e)
        {
            abrirForm(iconoVentas, new frmClientes());
        }

        private void iconoReportes_Click(object sender, EventArgs e)
        {
            abrirForm(iconoVentas, new frmReportes());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
