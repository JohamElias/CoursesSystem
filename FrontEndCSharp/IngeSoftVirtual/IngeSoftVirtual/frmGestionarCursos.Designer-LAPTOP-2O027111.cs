namespace IngeSoftVirtual
{
    partial class frmGestionarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarCursos));
            this.lblGestionCursos = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblClaveCurso = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.lblCreditosCurso = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionCursos
            // 
            this.lblGestionCursos.AutoSize = true;
            this.lblGestionCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCursos.Location = new System.Drawing.Point(12, 34);
            this.lblGestionCursos.Name = "lblGestionCursos";
            this.lblGestionCursos.Size = new System.Drawing.Size(150, 18);
            this.lblGestionCursos.TabIndex = 0;
            this.lblGestionCursos.Text = "Gestión de Cursos";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCurso.Location = new System.Drawing.Point(68, 74);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(94, 16);
            this.lblIDCurso.TabIndex = 1;
            this.lblIDCurso.Text = "Id del Curso:";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCurso.Location = new System.Drawing.Point(168, 71);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.ReadOnly = true;
            this.txtIDCurso.Size = new System.Drawing.Size(100, 22);
            this.txtIDCurso.TabIndex = 2;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(26, 158);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(136, 16);
            this.lblNombreCurso.TabIndex = 3;
            this.lblNombreCurso.Text = "Nombre del Curso:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(168, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(508, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(716, 27);
            this.tsMenu.TabIndex = 5;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "&Buscar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 24);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblClaveCurso
            // 
            this.lblClaveCurso.AutoSize = true;
            this.lblClaveCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCurso.Location = new System.Drawing.Point(41, 102);
            this.lblClaveCurso.Name = "lblClaveCurso";
            this.lblClaveCurso.Size = new System.Drawing.Size(121, 16);
            this.lblClaveCurso.TabIndex = 6;
            this.lblClaveCurso.Text = "Clave del Curso:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(168, 99);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(157, 22);
            this.txtClave.TabIndex = 7;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditos.Location = new System.Drawing.Point(168, 127);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(100, 22);
            this.txtCreditos.TabIndex = 8;
            // 
            // lblCreditosCurso
            // 
            this.lblCreditosCurso.AutoSize = true;
            this.lblCreditosCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditosCurso.Location = new System.Drawing.Point(23, 130);
            this.lblCreditosCurso.Name = "lblCreditosCurso";
            this.lblCreditosCurso.Size = new System.Drawing.Size(139, 16);
            this.lblCreditosCurso.TabIndex = 9;
            this.lblCreditosCurso.Text = "Créditos del Curso:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(59, 188);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(103, 16);
            this.lblEspecialidad.TabIndex = 10;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(168, 185);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(508, 24);
            this.cboEspecialidad.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(106, 220);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 16);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(45, 250);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(117, 16);
            this.lblFechaInicio.TabIndex = 13;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(83, 281);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(79, 16);
            this.lblFechaFin.TabIndex = 14;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(168, 217);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 22);
            this.txtPrecio.TabIndex = 15;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(168, 247);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(303, 22);
            this.dtpFechaInicio.TabIndex = 16;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(168, 278);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(303, 22);
            this.dtpFechaFin.TabIndex = 17;
            // 
            // frmGestionarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 330);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblCreditosCurso);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClaveCurso);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.txtIDCurso);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblGestionCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionarCursos";
            this.Text = "Formulario de Gestión de Cursos";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionCursos;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Label lblClaveCurso;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Label lblCreditosCurso;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}

