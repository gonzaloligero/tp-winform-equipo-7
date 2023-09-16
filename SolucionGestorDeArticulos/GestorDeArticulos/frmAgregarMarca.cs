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

namespace GestorDeArticulos
{
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca nueva = new Marca();
            MarcaManager manager = new MarcaManager();
            List<Marca> lista = new List<Marca>();  
            
            lista = manager.ListarMarcas();

            try
            {
                nueva.Descripcion = txtAgregarMarca.Text;
                if (!lista.Any(m => m.Descripcion.Equals(nueva.Descripcion, StringComparison.OrdinalIgnoreCase)))
                {
                    manager.Agregar(nueva);
                    MessageBox.Show("Agregada");
                    Close();
                }
                else { MessageBox.Show("Esa marca ya existe"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
