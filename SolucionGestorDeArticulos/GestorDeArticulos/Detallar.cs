﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using manager;

namespace winform_app
{
    public partial class frmDetallar : Form
    {
        private List<Articulo> listaArticulo;
        public frmDetallar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetallar_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;

        }

        private void btnDetallar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvArticulos.CurrentRow;
            Articulo articuloElegido = (Articulo)selectedRow.DataBoundItem;
            dgvDetalle.DataSource = new List<Articulo> { articuloElegido };
            pbxArticulo.ImageLocation = articuloElegido.Imagen;
            dgvDetalle.Columns["Id"].Visible = false;
            dgvDetalle.Columns["Imagen"].Visible = false;
        }

    }
}
