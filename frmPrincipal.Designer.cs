﻿namespace pryEstructurasDeDatos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDesarrollador = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCola = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdPila = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdListaSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdListaDoble = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdArbolBinario = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdRepasoOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdDesarrollador,
            this.cmdSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cmdDesarrollador
            // 
            this.cmdDesarrollador.Name = "cmdDesarrollador";
            this.cmdDesarrollador.Size = new System.Drawing.Size(144, 22);
            this.cmdDesarrollador.Text = "Desarrollador";
            this.cmdDesarrollador.Click += new System.EventHandler(this.cmdDesarrollador_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(144, 22);
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCola,
            this.cmdPila,
            this.toolStripSeparator1,
            this.cmdListaSimple,
            this.cmdListaDoble});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras Lineales";
            // 
            // cmdCola
            // 
            this.cmdCola.Name = "cmdCola";
            this.cmdCola.Size = new System.Drawing.Size(137, 22);
            this.cmdCola.Text = "Cola";
            this.cmdCola.Click += new System.EventHandler(this.cmdCola_Click);
            // 
            // cmdPila
            // 
            this.cmdPila.Name = "cmdPila";
            this.cmdPila.Size = new System.Drawing.Size(137, 22);
            this.cmdPila.Text = "Pila";
            this.cmdPila.Click += new System.EventHandler(this.cmdPila_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // cmdListaSimple
            // 
            this.cmdListaSimple.Name = "cmdListaSimple";
            this.cmdListaSimple.Size = new System.Drawing.Size(137, 22);
            this.cmdListaSimple.Text = "Lista Simple";
            this.cmdListaSimple.Click += new System.EventHandler(this.cmdListaSimple_Click);
            // 
            // cmdListaDoble
            // 
            this.cmdListaDoble.Name = "cmdListaDoble";
            this.cmdListaDoble.Size = new System.Drawing.Size(137, 22);
            this.cmdListaDoble.Text = "Lista Doble";
            this.cmdListaDoble.Click += new System.EventHandler(this.cmdListaDoble_Click);
            // 
            // estructurasNoLinealesToolStripMenuItem
            // 
            this.estructurasNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdArbolBinario});
            this.estructurasNoLinealesToolStripMenuItem.Name = "estructurasNoLinealesToolStripMenuItem";
            this.estructurasNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.estructurasNoLinealesToolStripMenuItem.Text = "Estructuras no Lineales";
            // 
            // cmdArbolBinario
            // 
            this.cmdArbolBinario.Name = "cmdArbolBinario";
            this.cmdArbolBinario.Size = new System.Drawing.Size(180, 22);
            this.cmdArbolBinario.Text = "Arbol Binario";
            this.cmdArbolBinario.Click += new System.EventHandler(this.cmdArbolBinario_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdOperaciones,
            this.cmdConsultas,
            this.toolStripSeparator2,
            this.cmdRepasoOperaciones});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // cmdOperaciones
            // 
            this.cmdOperaciones.Name = "cmdOperaciones";
            this.cmdOperaciones.Size = new System.Drawing.Size(293, 22);
            this.cmdOperaciones.Text = "Operaciones con tablas de bases de datos";
            this.cmdOperaciones.Click += new System.EventHandler(this.cmdOperaciones_Click);
            // 
            // cmdConsultas
            // 
            this.cmdConsultas.Name = "cmdConsultas";
            this.cmdConsultas.Size = new System.Drawing.Size(293, 22);
            this.cmdConsultas.Text = "Consultas en la Base de Datos";
            this.cmdConsultas.Click += new System.EventHandler(this.cmdConsultas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(290, 6);
            // 
            // cmdRepasoOperaciones
            // 
            this.cmdRepasoOperaciones.Name = "cmdRepasoOperaciones";
            this.cmdRepasoOperaciones.Size = new System.Drawing.Size(293, 22);
            this.cmdRepasoOperaciones.Text = "Repaso de Operaciones";
            this.cmdRepasoOperaciones.Click += new System.EventHandler(this.cmdRepasoOperaciones_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras de Datos - Lucas Valinotti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdDesarrollador;
        private System.Windows.Forms.ToolStripMenuItem cmdSalir;
        private System.Windows.Forms.ToolStripMenuItem cmdCola;
        private System.Windows.Forms.ToolStripMenuItem cmdPila;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmdListaSimple;
        private System.Windows.Forms.ToolStripMenuItem cmdListaDoble;
        private System.Windows.Forms.ToolStripMenuItem cmdArbolBinario;
        private System.Windows.Forms.ToolStripMenuItem cmdOperaciones;
        private System.Windows.Forms.ToolStripMenuItem cmdConsultas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmdRepasoOperaciones;
    }
}

