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
//CREATE PROCEDURE SP_ALL_HOSPITALES
//AS
//SELECT * FROM HOSPITAL
//GO
//EXEC SP_ALL_HOSPITALES
//create view V_EMPLEADOS_HOSPITAL
//as
//select DOCTOR.APELLIDO, DOCTOR.ESPECIALIDAD, DOCTOR.SALARIO
//, HOSPITAL.HOSPITAL_COD, HOSPITAL.NOMBRE
//from DOCTOR
//INNER JOIN HOSPITAL
//on DOCTOR.HOSPITAL_COD = HOSPITAL.HOSPITAL_COD
//UNION
//select PLANTILLA.APELLIDO, PLANTILLA.FUNCION, PLANTILLA.SALARIO
//, HOSPITAL.HOSPITAL_COD, HOSPITAL.NOMBRE
//from PLANTILLA
//INNER JOIN HOSPITAL
//on PLANTILLA.HOSPITAL_COD = HOSPITAL.HOSPITAL_COD
//go
//create procedure SP_EMPLEADOS_HOSPITAL
//(@nombre nvarchar(50), @suma int out, @media int out, @personas int out)
//as
//	select * from V_EMPLEADOS_HOSPITAL 
//	where NOMBRE=@nombre
//	select @suma = sum(salario), @media = avg(salario),
//    @personas = count(apellido) from V_EMPLEADOS_HOSPITAL
//	where NOMBRE=@nombre
//go
#endregion


namespace AdoNetCorePractica
{
    public partial class FormEmpleadosHospitales : Form
    {
        RepositoryEmpleadosHospital repo;
        public FormEmpleadosHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosHospital();
            this.LoadHospitalesAsync();
        }

        private async Task LoadHospitalesAsync()
        {
            List<string> nombres = await this.repo.GetHospitalesAsync();
            this.cmbHospitales.Items.Clear();
            foreach (string nombre in nombres)
            {
                this.cmbHospitales.Items.Add(nombre);
            }
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHospitales.SelectedIndex != -1)
            {
                string nombre =
                    this.cmbHospitales.SelectedItem.ToString();
                DatosEmpleados data =
                    await this.repo.GetDatosEmpleadosAsync(nombre);
                this.lstEmpleadosHospital.Items.Clear();
                foreach (Empleado emp in data.Empleados)
                {
                    this.lstEmpleadosHospital.Items.Add
                        (emp.Apellido + " - " + emp.Funcion + " - "
                        + emp.Salario);
                }
                this.txtSuma.Text = data.SumaSalarial.ToString();
                this.txtMedia.Text = data.MediaSalarial.ToString();
                this.txtPersonas.Text = data.Personas.ToString();
            }

        }
    }
}
