using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPractico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.ReadOnly = true;
            dgvLibros.Columns.Add("id", "ID");
            dgvLibros.Columns.Add("titulo", "Título");
            dgvLibros.Columns.Add("autor", "Autor");
            dgvLibros.Columns.Add("anio", "Anio");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
