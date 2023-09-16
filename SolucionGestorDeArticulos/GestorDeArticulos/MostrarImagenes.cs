﻿using System;
using winform_app;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominio;
using manager;

namespace GestorDeArticulos
{
    public partial class frmMostrarImagenes : Form
    {
        private List<Articulo> listaArticulo;
        public frmMostrarImagenes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

                private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenes.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenes.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");

            }
        }



        private void frmMostrarImagenes_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            //listaArticulo = articuloManager.ListarArticulos().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();
            dgvListaArticulos.DataSource = listaArticulo;
            dgvListaArticulos.Columns[3].Visible = false;
            dgvListaArticulos.Columns[4].Visible = false;
            dgvListaArticulos.Columns[5].Visible = false;
            dgvListaArticulos.Columns[6].Visible = false;
            dgvListaArticulos.Columns[7].Visible = false;
            cargarImagen(listaArticulo[0].Imagen);
          

        }

         private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        
    }


}
