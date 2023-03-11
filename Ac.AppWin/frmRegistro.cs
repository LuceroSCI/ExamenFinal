using A.Entidades;
using A.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ac.AppWin
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void cargarFormularios(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            dgvDatos.Rows.Clear();
            var listado = NotasBL.Listar();
            var lista = AlumnosBL.Listar();
            
            foreach (var alumnos in lista)
            {
                dgvDatos.Rows.Add(alumnos.Id, alumnos.Codigo, alumnos.Apellidos, alumnos.Nombres);
            }
            foreach (var notas in listado)
            {
                dgvDatos.Rows.Add(notas.Id, notas.IdCurso, notas.Eva1, notas.Parcial, notas.Eva2, notas.Final);
            }

            
        }
        private void NuevoRegistro(object sender, EventArgs e)
        {
            var nnotas = new Notas();
            var frm = new frmRegistroEdit(nnotas);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var resultado = NotasBL.Insertar(nnotas);
                if (resultado)
                {
                    MessageBox.Show("Datos registrados", "Sistemas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar los datos", "Sistemas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
    }
}
