using DataAccess.Models;
using Repository;

namespace Services
{
    public class busquedaServices
    {
        private busquedaRepository repository = new busquedaRepository();

        public List<Alumno> BuscarNombre (string buscar)
        {
            var list = repository.SearchName(buscar);
            return list;
        }
        public List<Alumno> BuscarCarrera(string buscar)
        {
            var list = repository.SearchCareer(buscar);
            return list;
        }

        public Alumno BuscarDni (int buscar)
        {
            var student = repository.SearchDni(buscar);
            return student;
        }
    }
}
