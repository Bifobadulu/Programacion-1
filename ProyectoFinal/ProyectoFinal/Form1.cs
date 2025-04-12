using System;
using System.Windows.Forms;
using InventarioPOO.Modelos;
using InventarioPOO.Servicios;
using ProyectoFinal.Modelos;

namespace InventarioPOO 
{
    public partial class Form1 : Form
    {
        private InventarioService servicio = new InventarioService();

        public Form1()
        {
            InitializeComponent();
            cmbCategoria.Items.Add("Limpieza");
            cmbCategoria.Items.Add("Alimentos");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null && ValidarCampos())
            {
                int index = dgvInventario.CurrentRow.Index;
                Producto actualizado = CrearProductoDesdeCampos();
                servicio.ModificarProducto(index, actualizado);
                RefrescarGrid();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null)
            {
                int index = dgvInventario.CurrentRow.Index;
                servicio.EliminarProducto(index);
                RefrescarGrid();
                LimpiarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Producto producto = CrearProductoDesdeCampos();
                servicio.AgregarProducto(producto);
                RefrescarGrid();
                LimpiarCampos();
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var producto = servicio.ObtenerInventario()[e.RowIndex];
                txtNombre.Text = producto.Nombre;
                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                cmbCategoria.SelectedItem = producto.Categoria;
            }
        }
        private Producto CrearProductoDesdeCampos()
        {
            Producto producto;
            if (cmbCategoria.SelectedItem.ToString() == "Limpieza")
                producto = new ProductoLimpieza();
            else
                producto = new ProductoAlimento();

            producto.Nombre = txtNombre.Text;
            producto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            producto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            producto.Categoria = cmbCategoria.SelectedItem.ToString();

            return producto;
        }

        private void RefrescarGrid()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = servicio.ObtenerInventario();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text)
                   && decimal.TryParse(txtPrecioCompra.Text, out _)
                   && decimal.TryParse(txtPrecioVenta.Text, out _)
                   && cmbCategoria.SelectedIndex != -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
