using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InicioSesion_MVC.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }



        public Usuarios(DataRow dr)
        {
            id = int.Parse(dr["id"].ToString());
            nombre = dr["nombre"].ToString();
            apellido = dr["apellido"].ToString();
            tipo_documento = dr["tipo_documento"].ToString();
            numero_documento = dr["numero_documento"].ToString();
            telefono = dr["telefono"].ToString();
            correo = dr["correo"].ToString();
            contraseña = dr["contraseña"].ToString();
        }
    }
}