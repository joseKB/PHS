﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsCuentaProveedores
    {
        private Conexion conexion  = new Conexion();

        SqlDataReader leer;
        DataTable tabla =new DataTable();
        SqlCommand comando =new SqlCommand();

        public DataTable consultarCuentaProveedores(string compañia, string codigo, string descripcion, int opc)
        {
            comando.Connection=conexion.AbrirConexion();
            comando.CommandText="consultarCuentaProveedores";
            comando.CommandType=CommandType.StoredProcedure;
            comando.Parameters.AddWithValue( "@compañia", compañia );
            comando.Parameters.AddWithValue( "@codigo", codigo );
            comando.Parameters.AddWithValue( "@descripcion", descripcion );
            comando.Parameters.AddWithValue( "@opc", opc );
            leer=comando.ExecuteReader();
            tabla.Load( leer );
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
