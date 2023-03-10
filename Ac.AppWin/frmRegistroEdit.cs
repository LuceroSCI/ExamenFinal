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
    public partial class frmRegistroEdit : Form
    {
        Notas _notas;
        public frmRegistroEdit(Notas notas)
        {
            InitializeComponent();

            this._notas = notas;
        }

        private void aceptarCambios(object sender, EventArgs e)
        {
            asignarDatos();
            this.DialogResult = DialogResult.OK;
        }
        private void CargarFormularios(object sender, EventArgs e)
        {
            cargarDatos();
        }
        //private void cargarFormulario(object sender, EventArgs e)
        // {
        //    cargarDatos();
        //}

        void cargarDatos()
        {
            var listadoAlumnos = AlumnosBL.Listar();
            cboAlumno.DataSource = listadoAlumnos;
            cboAlumno.DisplayMember = "Codigo";
            cboAlumno.DisplayMember = "Apellidos";
            cboAlumno.DisplayMember = "Nombres";
            cboAlumno.ValueMember = "Id";

            var listadoCursos = CursosBL.Listar();
            cboCurso.DataSource = listadoCursos;
            cboCurso.DisplayMember = "Nombre";
            cboCurso.ValueMember = "Id";
        }
        void asignarDatos()
        {
            this._notas.IdAulmno = int.Parse(cboAlumno.SelectedValue.ToString());
            this._notas.IdCurso = int.Parse(cboAlumno.SelectedValue.ToString());
            this._notas.Eva1= int.Parse(txtEva1.Text);
            this._notas.Parcial = int.Parse(txtParcial.Text);
            this._notas.Eva2= int.Parse(txtEva2.Text);
            this._notas.Final = int.Parse(txtFinal.Text);

            //this._notas.IdTipoCliente = int.Parse(cboTipoCliente.SelectedValue.ToString());
            // this._notas.Direccion = txtDireccion.Text;
            //this._notas.Referencia = txtReferencia.Text;
            //this._cliente.Telefono = txtTelefono.Text;
            //this._cliente.Email = txtEmail.Text;
        }

       
    }
}
