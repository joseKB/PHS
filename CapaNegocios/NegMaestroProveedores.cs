﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class NegMaestroProveedores
    {
        public static DataTable consultarMaestroProveedores(string buscar, int opc)
        {
            return new clsMaestroProveedores().consultarMaestroProveedores( buscar, opc );
        }
    }
}
