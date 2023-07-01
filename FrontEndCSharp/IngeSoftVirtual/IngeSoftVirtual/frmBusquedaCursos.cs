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
    public partial class frmListarCursos : Form
    {
        private ServiceWSClient _daoService = new ServiceWSClient();
        private curso curso;
        public curso _cursoSeleccionado { get => curso; set => curso = value; }
        public frmListarCursos()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource=_daoService.ListarCursoPorNombre(txtNombre.Text);
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            curso curso = (curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            dgvCursos.Rows[e.RowIndex].Cells[0].Value = curso.idCurso;
            dgvCursos.Rows[e.RowIndex].Cells[1].Value = curso.nombre;
            dgvCursos.Rows[e.RowIndex].Cells[2].Value = curso.especialidad.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvCursos.CurrentRow != null)
            {
                curso = (curso)dgvCursos.CurrentRow.DataBoundItem;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
