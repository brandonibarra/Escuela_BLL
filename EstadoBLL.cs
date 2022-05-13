using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escuela_DAL;

namespace Escuela_BLL
{
    public class EstadoBLL
    {
        public DataTable cargarEstados()
        {
            EstadoDAL estado = new EstadoDAL();

            return estado.cargarEstados();
        }
    }
}
