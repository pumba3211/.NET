using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinasRonald.Conexion
{
    public  interface IMetodosConexion
    {
        bool HayError { set; get; }
        string ErrorDescripcion { set; get; }
        Boolean Estado();

        // Método para manipular DQL (Select) Para busquedas escalares SUM(), Count(), Etc.
        SqlConnection  Conexion { set; get; }
        // Método para manipular DQL (Select) Exclusivo para carga de listas y combos
       
        bool HayTransaccion { set; get; }

        void LimpiarEstado();

        void IniciarTransaccion();

        void CommitTransaccion();

        void RollbackTransaccion();
    }
}
