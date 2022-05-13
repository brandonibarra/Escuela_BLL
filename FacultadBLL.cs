using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escuela_DAL;


namespace Escuela_BLL
{
    public class FacultadBLL
    {
        public List<Facultad> cargarFacultades()
        {
            FacultadDAL facultad = new FacultadDAL();
            return facultad.cargarFacultades();
        }

    }
}
