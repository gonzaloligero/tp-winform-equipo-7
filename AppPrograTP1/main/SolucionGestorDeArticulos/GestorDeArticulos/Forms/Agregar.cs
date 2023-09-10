﻿using System;
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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            GestorDeArticulos.Entidades.Articulo nuevoArticulo = new GestorDeArticulos.Entidades.Articulo();
            GestorDeArticulos.Managers.ArticuloManager nuevoManager = new GestorDeArticulos.Managers.ArticuloManager();
            try
            {
                nuevoArticulo.CodigoArt = txtCodigoArticulo.Text;
                nuevoArticulo.NombreArt = txtNombreArticulo.Text;
                nuevoArticulo.DescripcionArt = txtDescripcion.Text;
                nuevoArticulo.MarcaArt.Descripcion = txtMarca.Text;
                nuevoArticulo.CategoriaArt.Descripcion = txtCategoria.Text;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}