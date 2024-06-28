using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rocketCodeTest.Application.Interfaces;
using rocketCodeTest.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rocketCodeTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // Endpoint para obtener todos los usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            foreach (var user in users)
            {
                // Ejemplo de cómo manejar el campo SegundoNombre que puede ser NULL
                if (user.SegundoNombre == null)
                {
                    // Realizar alguna acción o asignar un valor predeterminado
                    user.SegundoNombre = "N/A";
                }
            }
            return Ok(users);
        }
        [HttpPost]
         public async Task<ActionResult<User>> AddUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userService.AddUserAsync(user);
                return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
            }
            catch (DbUpdateException)
            {
                // Aquí puedes manejar excepciones específicas de la base de datos
                return StatusCode(500, "Error al guardar los cambios en la base de datos. Por favor, intente nuevamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


    }
}
