using CapaPresentacion.Gestion_Productos.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            pProducto.Visible = false;
            pExistencias.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pProducto.Visible == true)
            {
                pProducto.Visible = false;
            }
            if (pExistencias.Visible == true)
            {
                pExistencias.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSPCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.TopLevel = false;
            pDesarrollo.Controls.Clear();
            pDesarrollo.Controls.Add(frm);
            lblTitulo.Text = "Lista de Categorias";
            frm.Show();
            hideSubMenu();
        }

        private void btnSPProducto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSPProveedor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSEEntradas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSESalidas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(pProducto);
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            showSubMenu(pExistencias);
        }
    }
}
