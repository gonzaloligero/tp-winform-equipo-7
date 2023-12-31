﻿using winform_app;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeArticulos;

namespace winform_app
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void tsmContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Maximiliano Soria y Gonzalo Ligero");
        }

        private void tsbContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Maximiliano Soria y Gonzalo Ligero");
        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(frmAgregar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregar ventana = new frmAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregar ventana = new frmAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmAlta_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListar ventana = new frmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmBuscar ventana = new frmBuscar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmModificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmDetallar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDetallar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmDetallar ventana = new frmDetallar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmAgregarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregar ventana = new frmAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmListarArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListar ventana = new frmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmBuscarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmBuscar ventana = new frmBuscar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmModificarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmDetallarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDetallar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmDetallar ventana = new frmDetallar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmContacto_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Maximiliano Soria y Gonzalo Ligero");
        }

        private void tsmEliminarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmEliminar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmEliminar ventana = new frmEliminar();
            ventana.MdiParent = this;
            ventana.Show();
        }


        private void tsbListar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListar ventana = new frmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmBuscar ventana = new frmBuscar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbDetallar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmDetallar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmDetallar ventana = new frmDetallar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmEliminar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmEliminar ventana = new frmEliminar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmCrearCategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmCrearCategoria))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmCrearCategoria ventana = new frmCrearCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmListarCategorias_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListarCategorias))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListarCategorias ventana = new frmListarCategorias();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmBorrarCategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmEliminarCategoria))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmEliminarCategoria ventana = new frmEliminarCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmModificarCategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificarCategoria))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificarCategoria ventana = new frmModificarCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmCrearMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregarMarca))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmListarMarcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmListarMarcas))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmListarMarcas ventana = new frmListarMarcas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmModificarMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificarMarca))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmModificarMarca ventana = new frmModificarMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregarImagenes))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregarImagenes ventana = new frmAgregarImagenes();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listadoConImágenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmMostrarImagenes))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmMostrarImagenes ventana = new frmMostrarImagenes();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregarImagenes))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmAgregarImagenes ventana = new frmAgregarImagenes();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbAlbum_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmMostrarImagenes))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmMostrarImagenes ventana = new frmMostrarImagenes();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsmEliminarMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmEliminarMarca))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            frmEliminarMarca ventana = new frmEliminarMarca();
            ventana.MdiParent = this;
            ventana.Show();

        }
        private void tsbYouTube_Click(object sender, EventArgs e)
        {
            MessageBox.Show("youtube.com/@MaxiPrograma");
        }

        private void tsbInstagram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("instagram.com/maxiprograma");
        }

        private void tsbLinkedinGonza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("linkedin.com/gonzaloligero");
        }

        private void tsbLinkedinMaxi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("linkedin.com/maximilianofacundosoria");
        }

    }
}
