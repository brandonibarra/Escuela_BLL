﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escuela_DAL;

namespace Escuela_BLL
{
   public class UsuarioBLL
    {
        public DataTable consultarUsuario(string nombre, string contraseña)
        {
            UsuarioDAL usuario = new UsuarioDAL();
            return usuario.consultarUsuario(nombre, contraseña);
        }
    }
}
