﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.Login.ClasesLogin
{
    public class BD
    {
        private SqlConnection conexion = new SqlConnection();

        private string datosConexion = Sistema.Instance.getDBConfigurations();

        #region Singleton
        private static volatile BD instancia = new BD();

        private BD()
        {
            conexion.ConnectionString = datosConexion;
        }

        public static BD getInstance()
        {
            return instancia;
        }
        #endregion

        public SqlDataReader getDataReader(string consulta, char tipoConsulta, List<SqlParameter> parametros)
        {
            //creo y cargo el comando para ejecutar
            SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;

            switch (tipoConsulta)
            {
                case 'T':
                    comando.CommandType = CommandType.Text;
                    break;
                case 'P':
                    comando.CommandType = CommandType.StoredProcedure;
                    break;
            }
            
            foreach (SqlParameter parametro in parametros)
            {
                comando.Parameters.Add(parametro);
            }

            //intento ejecutarlo
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                return dataReader;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void abrirConexion()
        {
            conexion.Open();
        }
    }
}
