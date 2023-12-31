﻿using dominio;
using manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GestorDeArticulos
{
    public partial class frmEliminar : Form
    {
        private List<Articulo> listaArticulo;
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.listaParaImagenes();
            dgvEliminar.DataSource = listaArticulo;
            dgvEliminar.Columns[0].Visible = false;
            dgvEliminar.Columns[6].Visible = false;
            //cargar(listaArticulo[0].Imagen);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloManager articulo = new ArticuloManager();
            Articulo seleccionado;
            try
            {
                seleccionado = dgvEliminar.CurrentRow.DataBoundItem as Articulo;
                articulo.eliminarArticulo(seleccionado.Id);
                MessageBox.Show("Articulo eliminado");
                
                listaArticulo = articulo.ListarArticulos();
                dgvEliminar.DataSource = listaArticulo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());              
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
