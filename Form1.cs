using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DesafioPractico1
{
    public partial class Form1 : Form
    {
        private readonly GestorBiblioteca gestorBiblioteca;
        private int? filtroUsuarioId = null; // Variable para almacenar el ID del usuario filtrado

        public Form1()
        {
            InitializeComponent();

            // Configuración de DataGridViews
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.ReadOnly = true;
            dgvLibros.AutoGenerateColumns = false;

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AutoGenerateColumns = false;

            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.AutoGenerateColumns = false;

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "Id"
            });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Título",
                DataPropertyName = "Titulo",
                Name = "Titulo"
            });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Autor",
                DataPropertyName = "Autor",
                Name = "Autor"
            });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Año",
                DataPropertyName = "Anio",
                Name = "Anio"
            });
            dgvLibros.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Disponible",
                DataPropertyName = "Disponible",
                Name = "Disponible",
                ReadOnly = true
            });

            
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "Id"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Name = "Nombre"
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Correo",
                DataPropertyName = "Email",
                Name = "Email"
            });


            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "Id"
            });
            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario",
                Name = "NombreUsuario"
            });
            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Libro",
                DataPropertyName = "TituloLibro",
                Name = "TituloLibro"
            });
            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha Prestamo",
                DataPropertyName = "FechaPrestamo",
                Name = "FechaPrestamo",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha Devolucion",
                DataPropertyName = "FechaDevolucion",
                Name = "FechaDevolucion",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvPrestamos.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Activo",
                DataPropertyName = "Activo",
                Name = "Activo",
                ReadOnly = true
            });

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
                MessageBox.Show("Libro agregado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MostrarError("El título no puede estar vacio!");
                return false;
            }
            else if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MostrarError("El nombre del autor no puede estar vacio!");
                return false;
            }
            else if (!int.TryParse(txtAnio.Text, out int anio) || anio <= 0)
            {
                MostrarError("El año debe ser un numero positivo!");
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
                if (MessageBox.Show("Esta seguro de eliminar este libro?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var id = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                    gestorBiblioteca.EliminarLibro(id);
                    MessageBox.Show("Libro eliminado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposLibro();
                    ActualizarGridLibros();
                    return;
                }
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
                ActualizarTodo();
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
                MostrarError("Debe seleccionar (una fila) usuario para editar.");
                return;
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                var id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                if (MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado? Se eliminarán todos los préstamos asociados a este usuario.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    gestorBiblioteca.EliminarUsuario(id);
                    MessageBox.Show("Usuario eliminado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (filtroUsuarioId.HasValue)
            {
                // Mostrar préstamos del usuario seleccionado, filtrados por activos si el checkbox está marcado
                var prestamos = chkPrestamosActivos.Checked
                    ? gestorBiblioteca.ObtenerPrestamosActivos().Where(p => p.IdUsuario == filtroUsuarioId.Value).ToList()
                    : gestorBiblioteca.ObtenerTodosPrestamos().Where(p => p.IdUsuario == filtroUsuarioId.Value).ToList();
                dgvPrestamos.DataSource = prestamos;
            }
            else
            {
                // Mostrar todos los préstamos, filtrados por activos si el checkbox está marcado
                dgvPrestamos.DataSource = chkPrestamosActivos.Checked
                    ? gestorBiblioteca.ObtenerPrestamosActivos()
                    : gestorBiblioteca.ObtenerTodosPrestamos();
            }
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
            ActualizarGridUsuarios();
            ActualizarGrafico();
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

                if (MessageBox.Show("Confirma la devolucion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
                MessageBox.Show("Seleccione un préstamo para devolver.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkPrestamosActivos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGridPrestamos();
        }

        private void btnFiltrarPrestamos_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedValue != null)
            {
                filtroUsuarioId = (int)cmbUsuarios.SelectedValue;
                ActualizarGridPrestamos();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para filtrar los préstamos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestablecerPrestamos_Click(object sender, EventArgs e)
        {
            filtroUsuarioId = null;
            ActualizarGridPrestamos();
            cmbUsuarios.SelectedIndex = -1; // Desseleccionar el usuario
        }

        private void ActualizarGrafico()
        {
            chartEstadisticas.Series.Clear();

            var series = new Series { ChartType = SeriesChartType.Column, Name = "Datos" };

            if (cmbTipoGrafico.SelectedIndex == 0)
            {
                chartEstadisticas.Titles.Clear();
                chartEstadisticas.Titles.Add("Usuarios Más Activos");
                var stats = gestorBiblioteca.ObtenerEstadisticasUsuarios();
                foreach (var stat in stats.OrderByDescending(x => x.Value).Take(10))
                {
                    series.Points.AddXY(stat.Key, stat.Value);
                }
            }
            else if (cmbTipoGrafico.SelectedIndex == 1)
            {
                chartEstadisticas.Titles.Clear();
                chartEstadisticas.Titles.Add("Libros Más Prestados");
                var stats = gestorBiblioteca.ObtenerEstadisticasLibros();
                foreach (var stat in stats.OrderByDescending(x => x.Value).Take(10))
                {
                    series.Points.AddXY(stat.Key, stat.Value);
                }
            }

            chartEstadisticas.Series.Add(series);
            chartEstadisticas.ChartAreas[0].AxisX.Interval = 1;
            chartEstadisticas.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartEstadisticas.ChartAreas[0].AxisY.Title = "Cantidad";
        }

        private void cmbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }
    }
}