using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //Se llama la referencia System.Configuration que fue agregada al proyecto previamente

namespace CapaDatos
{
   public  class Conexion
    {
        public static string cadena= ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
        //Esta clase contiene la cadena de conexión a la base de datos, que se obtiene del archivo de configuración (app.config de la CapaVisual).


    }
}
