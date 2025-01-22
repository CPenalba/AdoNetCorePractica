using AdoNetCorePractica.Helpers;
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
    public class RepositoryEmpleadosDepartamentos
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader; 

        public RepositoryEmpleadosDepartamentos()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<DatosDepratamentos> GetDatosDepartamentosAsync(string nombre)
        {
            string sql = "SP_DATOS_DEPARTAMENTOS";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosDepratamentos departamento = new DatosDepratamentos();
            while (await this.reader.ReadAsync())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string dnombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
               
                departamento.IdDepartamento = id;
                departamento.Nombre = dnombre;
                departamento.Localidad = localidad;
               
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return departamento;
        }
    }
}
