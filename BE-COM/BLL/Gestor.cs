using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;
namespace BLL
{
    public class Gestor
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void agregarUsuario()
        {

        }

        public void agregarRol(String pnombre, String pdescripcion, List<String> ppermisos)
        {

        }

        public void modificarUsuario()
        {

        }

        public void modificarRol()
        {

        }

        public void eliminarUsuario()
        {

        }

        public void eliminarRol()
        {

        }

        public IEnumerable<Permiso> obtenerPermisos()
        {
            return UoW.PermisoRepository.GetAll();
        }
    }
}
