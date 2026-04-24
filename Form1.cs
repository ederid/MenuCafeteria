using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;

namespace MenuCafeteria
{
    public partial class frmMenuCafeteria : Form
    {
        public frmMenuCafeteria()
        {
            InitializeComponent();
            CrearBaseDeDatos();
        }

        private void CrearBaseDeDatos()
        {
            string dbPath = "Data Source=database.db";

            using (SQLiteConnection conn = new SQLiteConnection(dbPath))
            {
                conn.Open();

                string query = @"CREATE TABLE IF NOT EXISTS Productos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre_Producto TEXT,
                        Precio TEXT,
                        Descripcion TEXT,
                        Categoria TEXT
                    );";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private string dbPath = "Data Source=database.db";

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(producto))
            {
                MessageBox.Show("El campo Producto no puede estar vacío", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (producto.Length <= 10)
            {
                MessageBox.Show("El texto debe tener más de 10 caracteres", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("El campo Descripción no puede estar vacío", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            if (descripcion.Length <= 10)
            {
                MessageBox.Show("El texto debe tener más de 10 caracteres", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    string query = @"INSERT INTO Productos (Nombre_Producto, Precio, Descripcion, Categoria) VALUES (@nombre, @precio, @descripcion, @categoria)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtProducto.Text.Trim());
                        cmd.Parameters.AddWithValue("@precio", txtPrecio.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Producto agregado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    string query = "SELECT Categoria, Nombre_Producto, Precio, Descripcion FROM Productos ORDER BY Categoria, Nombre_Producto";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);

                        dgvProductos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            double valor;

            if (double.TryParse(txtPrecio.Text, out valor))
            {
                // Formatear como moneda
                txtPrecio.Text = valor.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            }
            else
            {
                MessageBox.Show("Borre el contenido del texto e ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
            }
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Application.Exit();
        }

        private void frmMenuCafeteria_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void ReconstruirTabla()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("", conn))
                    {
                        // 1. Eliminar tabla existente con todos sus registros
                        cmd.CommandText = "DROP TABLE IF EXISTS Productos";
                        cmd.ExecuteNonQuery();

                        // 2. Recrear la tabla con Precio como TEXT
                        cmd.CommandText = @"CREATE TABLE Productos (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nombre_Producto TEXT,
                            Precio TEXT,
                            Descripcion TEXT,
                            Categoria TEXT
                        )";
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tabla recreada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos(); // Refrescar el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarMenu_Click(object sender, EventArgs e)
        {
            ReconstruirTabla();
        }

        private void LimpiarFormulario()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = "- Seleccione -";
            txtProducto.Focus();
        }
    }
}
