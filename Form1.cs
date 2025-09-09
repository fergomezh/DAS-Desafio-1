using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DesafioPractico1
{
    public partial class Form1 : Form
    {
        private readonly GestorBiblioteca gestorBiblioteca;

        public Form1()
        {
            InitializeComponent();

            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.ReadOnly = true;

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ReadOnly = true;

            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.ReadOnly = true;

            gestorBiblioteca = new GestorBiblioteca();
            ActualizarTodo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (ValidarCamposLibro())
            {
                gestorBiblioteca.AgregarLibro(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnio.Text));
                MessageBox.Show("Libro agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposLibro();
                ActualizarGridLibros();
            }
        }

        private bool MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidarCamposLibro()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MostrarError("El titulo no puede estar vacio!");
                return false;

            }
            else if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MostrarError("El nombre del autor no puede estar vacio!");
                return false;
            }
            else if (!int.TryParse(txtAnio.Text, out int anio) || anio <= 0)
            {
                MostrarError("El año debe ser un número positivo!");
                return false;
            }
            return true;
        }

        public void LimpiarCamposLibro()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtAnio.Text = "";
        }

        private void ActualizarGridLibros(string criterio = null)
        {
            dgvLibros.DataSource = null;
            var libros = string.IsNullOrEmpty(criterio) ? gestorBiblioteca.ObtenerLibros() : gestorBiblioteca.BuscarLibros(criterio);
            dgvLibros.DataSource = libros;
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 1 && ValidarCamposLibro())
            {
                var id = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                gestorBiblioteca.EditarLibro(id, txtTitulo.Text, txtAutor.Text, int.Parse(txtAnio.Text));
                LimpiarCamposLibro();
                ActualizarGridLibros();
                return;
            }
            else if (dgvLibros.SelectedRows.Count == 0 || dgvLibros.SelectedRows.Count > 1)
            {
                MostrarError("Debe seleccionar (una fila) libro para editar.");
                return;
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 1)
            {
                var id = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                gestorBiblioteca.EliminarLibro(id);
                LimpiarCamposLibro();
                ActualizarGridLibros();
                return;
            }
            else if (dgvLibros.SelectedRows.Count == 0 || dgvLibros.SelectedRows.Count > 1)
            {
                MostrarError("Debe seleccionar (una fila) libro para eliminar.");
                return;
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            ActualizarGridLibros(txtBuscar.Text);
        }

        private void ActualizarGridUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = gestorBiblioteca.ObtenerUsuarios();
        }

        private bool ValidarCamposUsuario()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MostrarError("El nombre no puede estar vacio!");
                return false;

            }
            else if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MostrarError("El correo no puede estar vacio!");
                return false;
            }
            else if (!txtCorreo.Text.Contains("@"))
            {
                MostrarError("El correo debe ser valido!");
                return false;
            }
            return true;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCamposUsuario())
            {
                gestorBiblioteca.AgregarUsuario(txtNombre.Text, txtCorreo.Text);
                LimpiarCamposUsuario();
                ActualizarGridUsuarios();
            }
        }

        public void LimpiarCamposUsuario()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1 && ValidarCamposUsuario())
            {
                var id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                gestorBiblioteca.EditarUsuario(id, txtNombre.Text, txtCorreo.Text);
                LimpiarCamposUsuario();
                ActualizarGridUsuarios();
                return;
            }
            else if (dgvUsuarios.SelectedRows.Count == 0 || dgvUsuarios.SelectedRows.Count > 1)
            {
                MostrarError("Debe seleccionar (una fila) libro para editar.");
                return;
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                var id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                if (MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado? Se eliminarán todos los préstamos asociados a este usuario.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    gestorBiblioteca.EliminarUsuario(id);
                    LimpiarCamposUsuario();
                    ActualizarGridUsuarios();
                }
                return;
            }
            else if (dgvUsuarios.SelectedRows.Count == 0 || dgvUsuarios.SelectedRows.Count > 1)
            {
                MostrarError("Debe seleccionar (una fila) usuario para eliminar.");
                return;
            }
        }

        private void ActualizarGridPrestamos()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = chkPrestamosActivos.Checked ? gestorBiblioteca.ObtenerPrestamosActivos() : gestorBiblioteca.ObtenerTodosPrestamos();
        }

        private void ActualizarComboBoxUsuarios()
        {
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = gestorBiblioteca.ObtenerUsuarios();
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "Id";
            cmbUsuarios.SelectedIndex = -1;
        }

        private void ActualizarComboBoxLibros()
        {
            cmbLibros.DataSource = null;
            cmbLibros.DataSource = gestorBiblioteca.ObtenerLibrosDisponibles();
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "Id";
            cmbLibros.SelectedIndex = -1;
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedValue != null && cmbLibros.SelectedValue != null)
            {
                var idUsuario = (int)cmbUsuarios.SelectedValue;
                var idLibro = (int)cmbLibros.SelectedValue;

                if (gestorBiblioteca.RealizarPrestamo(idUsuario, idLibro))
                {
                    MessageBox.Show("Prestamo realizado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTodo();
                }
                else
                {
                    MostrarError("No se pudo realizar el prestamo. Verifique que el libro este disponible!");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario y un libro.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarTodo()
        {
            ActualizarComboBoxLibros();
            ActualizarComboBoxUsuarios();
            ActualizarGridLibros();
            ActualizarGridPrestamos();
            ActualizarGridPrestamos();
            ActualizarGridUsuarios();
        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 1)
            {
                var id = (int)dgvPrestamos.SelectedRows[0].Cells["Id"].Value;
                var activo = (bool)dgvPrestamos.SelectedRows[0].Cells["Activo"].Value;

                if (!activo)
                {
                    MessageBox.Show("Este libro ya fue devuelto!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Cofirma la devolucion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (gestorBiblioteca.DevolverLibro(id))
                    {
                        MessageBox.Show("Libro devuelto con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarTodo();
                    }
                    else
                    {
                        MostrarError("Error al devolver el libro!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un prestamo para devolver.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkPrestamosActivos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGridPrestamos();
        }
    }
}

