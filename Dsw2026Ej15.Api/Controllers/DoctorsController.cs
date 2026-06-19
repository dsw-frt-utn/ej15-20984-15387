using Dsw2026Ej15.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2026Ej15.Api.Controllers
{
    // Aqui indicamos al programa que esta clase es un controlador de API
    [ApiController]
    // Definimos la ruta web. En este caso sera: http://localhost:xxxx/api/Doctors
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        // Variable privada para la conexion con la base de datos simulada
        private readonly IPersistence _persistence;

        // El constructor inyecta la dependencia
        public DoctorsController(IPersistence persistence)
        {
            _persistence = persistence;
        }

        // Metodo GET para obtener la lista de medicos
        [HttpGet]
        public IActionResult Get()
        {
            // Devolvemos un estado 200 (OK) con la lista de medicos (actualmente vacia en memoria)
            return Ok(_persistence.Doctors);
        }
    }
}