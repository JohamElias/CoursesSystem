using IngeSoftVirtual.ServiceWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngeSoftVirtual
{
    public partial class frmGestionarCursos : Form
    {
        private Estado _estado;
        private curso _curso;
        private ServiceWSClient _serviceWSClient=new ServiceWSClient();
        public frmGestionarCursos()
        {
            InitializeComponent();
            this._estado = Estado.Inicial;
            cboEspecialidad.ValueMember = "idEspecialidad";
            cboEspecialidad.DisplayMember = "nombre";
            estadoComponentes();
        }

        public void limpiarComponentes()
        {
            txtIDCurso.Text = "";
            txtClave.Text = "";
            txtCreditos.Text = "";
            txtNombre.Text = "";
            cboEspecialidad.SelectedIndex = -1;
            txtPrecio.Text = "";
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
        }

        public void estadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    txtIDCurso.Enabled = false;
                    txtClave.Enabled = false;
                    txtCreditos.Enabled = false;
                    txtNombre.Enabled = false;
                    cboEspecialidad.Enabled = false;
                    txtPrecio.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDCurso.Enabled = true;
                    txtClave.Enabled = true;
                    txtCreditos.Enabled = true;
                    txtNombre.Enabled = true;
                    cboEspecialidad.Enabled = true;
                    txtPrecio.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            estadoComponentes();
            limpiarComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            estadoComponentes();
            limpiarComponentes();
            cboEspecialidad.DataSource = _serviceWSClient.ListarTodasEspecialidades();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmListarCursos frmListarCursos = new frmListarCursos();
            if (frmListarCursos.ShowDialog() == DialogResult.OK)
            {
                _curso=frmListarCursos._cursoSeleccionado;
                txtIDCurso.Text = _curso.idCurso.ToString();
                txtNombre.Text = _curso.nombre;
                txtClave.Text = _curso.clave;
                txtCreditos.Text=_curso.creditos.ToString();
                txtPrecio.Text = _curso.precio.ToString();
                dtpFechaInicio.Value = _curso.fechaInicio;
                dtpFechaFin.Value = _curso.fechaFin;
                cboEspecialidad.SelectedValue = _curso.especialidad.idEspecialidad;
                cboEspecialidad.Text = _curso.especialidad.nombre;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _curso=new curso();
            _curso.nombre = txtNombre.Text;
            _curso.precio = Double.Parse(txtPrecio.Text);
            _curso.especialidad = new especialidad();
            _curso.especialidad.idEspecialidad = (int)cboEspecialidad.SelectedValue;
            _curso.clave=txtClave.Text;
            _curso.creditos = Int32.Parse(txtCreditos.Text);
            _curso.fechaInicio = dtpFechaInicio.Value;
            _curso.fechaInicioSpecified = true;
            _curso.fechaFin = dtpFechaFin.Value;
            _curso.fechaFinSpecified = true;
            int resultado = _serviceWSClient.InsertarCurso(_curso);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCurso.Text = resultado.ToString();
                _estado = Estado.Inicial;
                estadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
