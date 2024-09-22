using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Gestion_Productos.Categorias
{
    public partial class frmCategoria : Form
    {
        lCategoria oCategoria = new lCategoria();
        // Constructor del formulario y actualizacion de tabla
        public frmCategoria()
        {
            InitializeComponent();
            dgvCategoria.DataSource = oCategoria.Listar(int.Parse(lblContador.Text));
            lblTotal.Text = oCategoria.Valor().ToString();
        }
        // Evento de carga del formulario y edicion de la columna ID
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            dgvCategoria.Columns["ID"].Width = 130;
            dgvCategoria.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        // Evento que se dispara al cambiar el texto del cuadro de búsqueda de Categoria
        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCategoria.Text != "")
            {
                dgvCategoria.DataSource = oCategoria.Buscar(txtBuscarCategoria.Text);
            }
            else
            {
                dgvCategoria.DataSource = oCategoria.Listar(int.Parse(lblContador.Text));
                lblTotal.Text = oCategoria.Valor().ToString();
            }
        }
        // Evento del botón para avanzar en la paginación de las categorías
        private void btnAdelante_Click(object sender, EventArgs e)
        {      
            lblContador.Text = (int.Parse(lblContador.Text) + 1).ToString();
            lblCont.Text = lblContador.Text;
            dgvCategoria.DataSource = oCategoria.Listar(int.Parse(lblContador.Text));
            lblTotal.Text = oCategoria.Valor().ToString();
        }
        // Evento del botón para retroceder en la paginación de las categorías
        private void btnAtras_Click(object sender, EventArgs e)
        {
            int contadorActual = int.Parse(lblContador.Text);
            if (contadorActual <= 1)
            {
                return;
            }
            lblContador.Text = (contadorActual - 1).ToString();
            lblCont.Text = lblContador.Text;
            dgvCategoria.DataSource = oCategoria.Listar(contadorActual - 1);
            lblTotal.Text = oCategoria.Valor().ToString();
        }
        // Función que actualiza el texto del botón según el radio button seleccionado
        private void ActualizarTextoBoton()
        {
            if (rbAgregar.Checked)
            {
                btnFuncion.Text = "Agregar Categoria";
            }
            else if (rbModificar.Checked)
            {
                btnFuncion.Text = "Modificar Categoria";
            }
            else if (rbEliminar.Checked)
            {
                btnFuncion.Text = "Eliminar Categoria";
            }
            else
            {
                btnFuncion.Text = "";
            }
        }
        // Evento que detecta cuando se selecciona el radio button para agregar
        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTextoBoton();
        }
        // Evento que detecta cuando se selecciona el radio button para modificar
        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTextoBoton();
        }
        // Evento que detecta cuando se selecciona el radio button para eliminar
        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTextoBoton();
        }
        // Evento del botón principal que ejecuta agregar, modificar o eliminar según la opción seleccionada
        private void btnFuncion_Click(object sender, EventArgs e)
        {
            oCategoria.nombre = txtCategoria.Text;
            oCategoria.id = !string.IsNullOrEmpty(txtCodigo.Text) ? int.Parse(txtCodigo.Text) : 0;

            if (rbAgregar.Checked)
            {
                oCategoria.Insertar();
            }
            else if (rbModificar.Checked)
            {
                oCategoria.Modificar();
            }
            else if (rbEliminar.Checked)
            {
                oCategoria.Eliminar();
            }

            dgvCategoria.DataSource = oCategoria.Listar(int.Parse(lblContador.Text));
            lblTotal.Text = oCategoria.Valor().ToString();
        }
        // Método que se ejecuta cuando se hace clic en una celda del DataGridView y autocomplementar en los textbox
        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvCategoria.Rows[e.RowIndex];

                // Autocompletar los TextBox con los valores de la fila
                txtCodigo.Text = row.Cells["Id"].Value.ToString();
                txtCategoria.Text = row.Cells["Nombre"].Value.ToString();
            }
        }
    }
}
