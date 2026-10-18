using InicioSesion_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InicioSesion_MVC.Controllers
{
    public class UsuariosDAO
    {
        Db db = new Db("InicioSesion");

  
        public Usuarios Index(string correo, string contraseña)
        {
            string consulta = "SELECT * FROM dbo.usuarios " +
                              "WHERE correo = @correo AND contraseña = @contraseña";
            db.Sentencia(consulta);
            db.Parametro("@correo", correo.Trim());
            db.Parametro("@contraseña", contraseña);

            DataTable usuarios = db.getDataTable();
            if (usuarios != null && usuarios.Rows.Count > 0)
            {
                Usuarios resultado = new Usuarios(usuarios.Rows[0]);
                return resultado;
            }
            return null;
        }
    }
}