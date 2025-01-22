using AdoNetCorePractica.Models;
using AdoNetCorePractica.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region
//create procedure SP_ALL_DEPARTAMENTOS
//as
//select * from DEPT
//go
//CREATE PROCEDURE SP_DATOS_DEPARTAMENTOS
//(@nombre nvarchar(50))
//AS
//SELECT * FROM DEPT WHERE DNOMBRE=@nombre
//GO
#endregion

namespace AdoNetCorePractica
{
    public partial class FormPracticaEmpleadosDepartamentos : Form
    {
        RepositoryEmpleadosDepartamentos repo;
        public FormPracticaEmpleadosDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosDepartamentos();
            this.LoadDepartamentosAsync();
        }
        private async Task LoadDepartamentosAsync()
        {
            List<string> nombres = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string nombre in nombres)
            {
                this.cmbDepartamentos.Items.Add(nombre);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            DatosDepratamentos model =
                await this.repo.GetDatosDepartamentosAsync(nombre);
            this.txtNombre.Text = model.Nombre;
            this.txtId.Text = model.IdDepartamento.ToString(); // Asignar el ID
            this.txtLocalidad.Text = model.Localidad;
        }
    }
}
