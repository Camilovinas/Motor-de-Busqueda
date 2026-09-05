using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BusquedaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusquedaController : ControllerBase
    {
        private readonly busquedaServices _busquedaServices = new busquedaServices();

        [HttpGet("BuscarNombre")]
        public ActionResult<List<Alumno>> getAlumnoByName(string search)
        {
            var list = _busquedaServices.BuscarNombre(search);

            if (list.Count == 0)
            {
                return NotFound("no encontrado.");
            }

            return Ok(list);
        }

        [HttpGet("BuscarCarrera")]
        public ActionResult<List<Alumno>> getAlumnoByCareer(string search)
        {
            var list = _busquedaServices.BuscarCarrera(search);

            if (list.Count == 0)
            {
                return NotFound("no encontrado.");
            }

            return Ok(list);
        }

        [HttpGet("BuscarDni")]
        public ActionResult<Alumno> getAlumnoByDni(int search)
        {
            var student = _busquedaServices.BuscarDni(search);

            if (student.Name == "empty")
            {
                return NotFound("no encontrado.");
            }

            return Ok(student);
        }

    }
}
