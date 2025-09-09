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

            gestorBiblioteca = new GestorBiblioteca();
            ActualizarGridLibros();
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
            }
            else if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MostrarError("El nombre del autor no puede estar vacio!");
            }
            else if (!int.TryParse(txtAnio.Text, out int anio) || anio <= 0)
            {
                MostrarError("El año debe ser un número positivo!");
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
            }
            else if(dgvLibros.SelectedRows.Count == 0)
            {
                MostrarError("Debe seleccionar (una fila) libro para editar.");
            }
        }
    }
}
