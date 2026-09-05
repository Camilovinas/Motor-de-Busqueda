using DataAccess;
using DataAccess.Models;

namespace Repository
{
    
    public class busquedaRepository
    {
        private AppDbContext context = new AppDbContext();

        public List<Alumno> SearchName(string search)
        {
            var list = context.Alumnos.Where(x => x.Name.ToUpper().Contains(search.ToUpper()) || x.SurName.ToUpper().Contains(search.ToUpper())).ToList();
            return list;
        }

        public List<Alumno> SearchCareer(string search)
        {
            var list = context.Alumnos.Where(x => x.Career.ToUpper().Contains(search.ToUpper())).ToList();
            return list;
        }
        public Alumno SearchDni(int search)
        {
            var found = context.Alumnos.FirstOrDefault(x => x.Dni == search);
            Alumno student = new Alumno("empty", "empty", 0, "empty", 0);

            if (found != null)
            {
                student = found;
            }

            return student;
        }

    }
}
