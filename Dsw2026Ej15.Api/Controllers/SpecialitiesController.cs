using Dsw2026Ej15.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2026Ej15.Api.Controllers
{
    // Aqui indicamos al programa que esta clase es un controlador de API
    [ApiController]
    // Definimos la ruta web. En este caso sera algo como: http://localhost:xxxx/api/Specialities
    [Route("api/[controller]")]
    public class SpecialitiesController : ControllerBase
    {
        // Variable privada para guardar nuestra memoria simulada
        private readonly IPersistence _persistence;

        // El constructor recibe la conexion que armo Natalia en el Program.cs
        public SpecialitiesController(IPersistence persistence)
        {
            _persistence = persistence;
        }

        // Metodo GET para obtener la lista cuando entremos a la URL
        [HttpGet]
        public IActionResult Get()
        {
            // Devolvemos un estado 200 (OK) junto con la lista de especialidades que leimos del archivo JSON
            return Ok(_persistence.Specialities);
        }
    }
}