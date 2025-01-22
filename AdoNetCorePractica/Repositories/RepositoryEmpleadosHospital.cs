﻿using AdoNetCorePractica.Helpers;
using AdoNetCorePractica.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Repositories
{
    public class RepositoryEmpleadosHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryEmpleadosHospital()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetHospitalesAsync()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> hospitales = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task<DatosEmpleados> GetDatosEmpleadosAsync(string nombre)
        {
            string sql = "SP_EMPLEADOS_HOSPITAL";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter pamSuma = new SqlParameter("@suma", 0);
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter("@media", 0);
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter("@personas", 0);
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleados data = new DatosEmpleados();
            List<Empleado> empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["ESPECIALIDAD"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                Empleado empleado = new Empleado();
                empleado.Apellido = apellido;
                empleado.Funcion = funcion;
                empleado.Salario = salario;
                empleados.Add(empleado);
            }
            await this.reader.CloseAsync();
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            data.Empleados = empleados;
            data.SumaSalarial = suma;
            data.MediaSalarial = media;
            data.Personas = personas;
            return data;
        }
    }
}
