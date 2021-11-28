using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Proyecto4
{
    class cMiembro
    {
        /*Este método sirve para poblar la tabla cuando se usa el botón "Actualizar listado"*/
        cConexion nmc = new cConexion();
        public DataSet consultar()
        {
            return nmc.buscar("select * from miembros", "miembros");
        }
    }
}
