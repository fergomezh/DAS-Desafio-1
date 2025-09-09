namespace DesafioPractico1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPrestamos = new System.Windows.Forms.TabPage();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.chkPrestamosActivos = new System.Windows.Forms.CheckBox();
            this.btnDevolverLibro = new System.Windows.Forms.Button();
            this.btnRealizarPrestamo = new System.Windows.Forms.Button();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.btnFiltrarPrestamos = new System.Windows.Forms.Button();
            this.btnRestablecerPrestamos = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.tabEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLibros);
            this.tabControl.Controls.Add(this.tabUsuarios);
            this.tabControl.Controls.Add(this.tabPrestamos);
            this.tabControl.Controls.Add(this.tabEstadisticas);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1064, 644);
            this.tabControl.TabIndex = 0;
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.dgvLibros);
            this.tabLibros.Controls.Add(this.btnEliminarLibro);
            this.tabLibros.Controls.Add(this.btnEditarLibro);
            this.tabLibros.Controls.Add(this.btnBuscarLibro);
            this.tabLibros.Controls.Add(this.btnAgregarLibro);
            this.tabLibros.Controls.Add(this.txtAnio);
            this.tabLibros.Controls.Add(this.lblAnio);
            this.tabLibros.Controls.Add(this.txtAutor);
            this.tabLibros.Controls.Add(this.lblAutor);
            this.tabLibros.Controls.Add(this.txtBuscar);
            this.tabLibros.Controls.Add(this.txtTitulo);
            this.tabLibros.Controls.Add(this.lblBuscar);
            this.tabLibros.Controls.Add(this.lblTitulo);
            this.tabLibros.Location = new System.Drawing.Point(4, 25);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibros.Size = new System.Drawing.Size(1056, 615);
            this.tabLibros.TabIndex = 0;
            this.tabLibros.Text = "Gestion de Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(3, 148);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(1050, 464);
            this.dgvLibros.TabIndex = 5;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(308, 47);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(128, 43);
            this.btnEliminarLibro.TabIndex = 4;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.Location = new System.Drawing.Point(157, 47);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Size = new System.Drawing.Size(128, 43);
            this.btnEditarLibro.TabIndex = 4;
            this.btnEditarLibro.Text = "Editar";
            this.btnEditarLibro.UseVisualStyleBackColor = true;
            this.btnEditarLibro.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(343, 99);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(128, 43);
            this.btnBuscarLibro.TabIndex = 4;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(10, 47);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(128, 43);
            this.btnAgregarLibro.TabIndex = 4;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(736, 15);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(111, 22);
            this.txtAnio.TabIndex = 3;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(685, 15);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(34, 16);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Anio";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(415, 15);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(234, 22);
            this.txtAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(364, 15);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(44, 16);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(57, 109);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(269, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(57, 15);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(269, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(7, 109);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(7, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.tabUsuarios.Controls.Add(this.btnEditarUsuario);
            this.tabUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuarios.Controls.Add(this.txtCorreo);
            this.tabUsuarios.Controls.Add(this.lblCorreo);
            this.tabUsuarios.Controls.Add(this.txtNombre);
            this.tabUsuarios.Controls.Add(this.lblNombre);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(1056, 615);
            this.tabUsuarios.TabIndex = 1;
            this.tabUsuarios.Text = "Gestion de Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 127);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1050, 488);
            this.dgvUsuarios.TabIndex = 8;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(321, 63);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(128, 43);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(170, 63);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(128, 43);
            this.btnEditarUsuario.TabIndex = 6;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(23, 63);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(128, 43);
            this.btnAgregarUsuario.TabIndex = 7;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(428, 20);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(249, 22);
            this.txtCorreo.TabIndex = 1;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(362, 20);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 16);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tabPrestamos
            // 
            this.tabPrestamos.Controls.Add(this.dgvPrestamos);
            this.tabPrestamos.Controls.Add(this.chkPrestamosActivos);
            this.tabPrestamos.Controls.Add(this.btnRestablecerPrestamos);
            this.tabPrestamos.Controls.Add(this.btnFiltrarPrestamos);
            this.tabPrestamos.Controls.Add(this.btnDevolverLibro);
            this.tabPrestamos.Controls.Add(this.btnRealizarPrestamo);
            this.tabPrestamos.Controls.Add(this.cmbLibros);
            this.tabPrestamos.Controls.Add(this.cmbUsuarios);
            this.tabPrestamos.Controls.Add(this.lblLibro);
            this.tabPrestamos.Controls.Add(this.lblUsuario);
            this.tabPrestamos.Location = new System.Drawing.Point(4, 25);
            this.tabPrestamos.Name = "tabPrestamos";
            this.tabPrestamos.Size = new System.Drawing.Size(1056, 615);
            this.tabPrestamos.TabIndex = 2;
            this.tabPrestamos.Text = "Gestion de Prestamos";
            this.tabPrestamos.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(3, 136);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(1050, 476);
            this.dgvPrestamos.TabIndex = 10;
            // 
            // chkPrestamosActivos
            // 
            this.chkPrestamosActivos.AutoSize = true;
            this.chkPrestamosActivos.Location = new System.Drawing.Point(20, 110);
            this.chkPrestamosActivos.Name = "chkPrestamosActivos";
            this.chkPrestamosActivos.Size = new System.Drawing.Size(216, 20);
            this.chkPrestamosActivos.TabIndex = 9;
            this.chkPrestamosActivos.Text = "Mostrar solo prestamos activos";
            this.chkPrestamosActivos.UseVisualStyleBackColor = true;
            this.chkPrestamosActivos.CheckedChanged += new System.EventHandler(this.chkPrestamosActivos_CheckedChanged);
            // 
            // btnDevolverLibro
            // 
            this.btnDevolverLibro.Location = new System.Drawing.Point(204, 51);
            this.btnDevolverLibro.Name = "btnDevolverLibro";
            this.btnDevolverLibro.Size = new System.Drawing.Size(165, 43);
            this.btnDevolverLibro.TabIndex = 8;
            this.btnDevolverLibro.Text = "Devolver Seleccionado";
            this.btnDevolverLibro.UseVisualStyleBackColor = true;
            this.btnDevolverLibro.Click += new System.EventHandler(this.btnDevolverLibro_Click);
            // 
            // btnRealizarPrestamo
            // 
            this.btnRealizarPrestamo.Location = new System.Drawing.Point(20, 51);
            this.btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            this.btnRealizarPrestamo.Size = new System.Drawing.Size(165, 43);
            this.btnRealizarPrestamo.TabIndex = 8;
            this.btnRealizarPrestamo.Text = "Realizar Prestamo";
            this.btnRealizarPrestamo.UseVisualStyleBackColor = true;
            this.btnRealizarPrestamo.Click += new System.EventHandler(this.btnRealizarPrestamo_Click);
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(433, 11);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(228, 24);
            this.cmbLibros.TabIndex = 1;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(92, 11);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(228, 24);
            this.cmbUsuarios.TabIndex = 1;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(358, 14);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(37, 16);
            this.lblLibro.TabIndex = 0;
            this.lblLibro.Text = "Libro";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Controls.Add(this.chartEstadisticas);
            this.tabEstadisticas.Controls.Add(this.cmbTipoGrafico);
            this.tabEstadisticas.Controls.Add(this.lblGrafico);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 25);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadisticas.Size = new System.Drawing.Size(1056, 615);
            this.tabEstadisticas.TabIndex = 3;
            this.tabEstadisticas.Text = "Estadisticas";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // chartEstadisticas
            // 
            chartArea3.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend3);
            this.chartEstadisticas.Location = new System.Drawing.Point(23, 60);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartEstadisticas.Series.Add(series3);
            this.chartEstadisticas.Size = new System.Drawing.Size(1018, 549);
            this.chartEstadisticas.TabIndex = 2;
            this.chartEstadisticas.Text = "chart1";
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.FormattingEnabled = true;
            this.cmbTipoGrafico.Items.AddRange(new object[] {
            "Usuarios Mas Activos",
            "Libros Mas Prestados"});
            this.cmbTipoGrafico.Location = new System.Drawing.Point(143, 17);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(243, 24);
            this.cmbTipoGrafico.TabIndex = 1;
            this.cmbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGrafico_SelectedIndexChanged);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(20, 20);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(103, 16);
            this.lblGrafico.TabIndex = 0;
            this.lblGrafico.Text = "Tipo de Grafico:";
            // 
            // btnFiltrarPrestamos
            // 
            this.btnFiltrarPrestamos.Location = new System.Drawing.Point(388, 51);
            this.btnFiltrarPrestamos.Name = "btnFiltrarPrestamos";
            this.btnFiltrarPrestamos.Size = new System.Drawing.Size(165, 43);
            this.btnFiltrarPrestamos.TabIndex = 8;
            this.btnFiltrarPrestamos.Text = "Filtrar por Usuario";
            this.btnFiltrarPrestamos.UseVisualStyleBackColor = true;
            this.btnFiltrarPrestamos.Click += new System.EventHandler(this.btnFiltrarPrestamos_Click);
            // 
            // btnRestablecerPrestamos
            // 
            this.btnRestablecerPrestamos.Location = new System.Drawing.Point(570, 51);
            this.btnRestablecerPrestamos.Name = "btnRestablecerPrestamos";
            this.btnRestablecerPrestamos.Size = new System.Drawing.Size(165, 43);
            this.btnRestablecerPrestamos.TabIndex = 8;
            this.btnRestablecerPrestamos.Text = "Restablecer Filtro";
            this.btnRestablecerPrestamos.UseVisualStyleBackColor = true;
            this.btnRestablecerPrestamos.Click += new System.EventHandler(this.btnRestablecerPrestamos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 662);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabLibros.ResumeLayout(false);
            this.tabLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabPrestamos.ResumeLayout(false);
            this.tabPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.tabEstadisticas.ResumeLayout(false);
            this.tabEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabPrestamos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnEditarLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.CheckBox chkPrestamosActivos;
        private System.Windows.Forms.Button btnDevolverLibro;
        private System.Windows.Forms.Button btnRealizarPrestamo;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private System.Windows.Forms.Button btnFiltrarPrestamos;
        private System.Windows.Forms.Button btnRestablecerPrestamos;
    }
}

