﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructurasDeDatos
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila PilaDePersonas = new clsPila();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            objNodo.Nombre = txtNuevoNombre.Text;
            objNodo.Tramite = txtNuevoTramite.Text;
            PilaDePersonas.Agregar(objNodo);
            PilaDePersonas.Recorrer(dgvGrilla);
            PilaDePersonas.Recorrer(lstLista);
            PilaDePersonas.Recorrer();
            txtNuevoCodigo.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDePersonas.Primero != null)
            {
                lblCodigo.Text = PilaDePersonas.Primero.Codigo.ToString();
                lblNombre.Text = PilaDePersonas.Primero.Nombre;
                lblTramite.Text = PilaDePersonas.Primero.Tramite;
                PilaDePersonas.Eliminar();
                PilaDePersonas.Recorrer(dgvGrilla);
                PilaDePersonas.Recorrer(lstLista);
                PilaDePersonas.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}
