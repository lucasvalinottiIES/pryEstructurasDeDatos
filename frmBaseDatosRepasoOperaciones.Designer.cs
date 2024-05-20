namespace pryEstructurasDeDatos
{
    partial class frmBaseDatosRepasoOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDatosRepasoOperaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operación a Realizar:";
            // 
            // cboOperacion
            // 
            this.cboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "1. Proyeccion Simple",
            "2. Proyeccion Simple 2",
            "3.Proyeccion Multiatributo",
            "4. Proyeccion Multiatributo 2",
            "5. Juntar Tablas",
            "6. Juntar Tablas 3",
            "7. Seleccion Simple",
            "8. Seleccion Simple 2",
            "9. Seleccion Multiatributo",
            "10. Seleccion Multiatributo 2",
            "11. Seleccion Por Convolucion",
            "12. Seleccion Por Convolucion 2",
            "13. Union",
            "14. Union 2",
            "15. Interseccion",
            "16. Interseccion 2",
            "17 Diferencia",
            "18. Diferencia 2",
            "19. Juntar Tablas 3",
            "20. Diferencia 3"});
            this.cboOperacion.Location = new System.Drawing.Point(129, 12);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(520, 21);
            this.cboOperacion.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(667, 10);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnunciado.Location = new System.Drawing.Point(16, 51);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(726, 153);
            this.lblEnunciado.TabIndex = 3;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(16, 218);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(726, 220);
            this.dgvGrilla.TabIndex = 4;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.DataGridView dgvGrilla;
    }
}