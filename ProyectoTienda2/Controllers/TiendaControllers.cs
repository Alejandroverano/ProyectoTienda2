using Microsoft.AspNetCore.JsonPatch;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ProyectoTienda.Data;
using SchoolAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using ProyectoTienda.Models;

namespace ProyectoTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaControllers : ControllerBase
    {
        private readonly ProyectoTiendaContext _db;
        private readonly ILogger<TiendaControllers> _logger;

        public TiendaControllers(ILogger<TiendaControllers> logger, ProyectoTiendaContext db)
        {
            _logger = logger;
            _db = db;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetStudents()
        {
            _logger.LogInformation("Obtener los productos");
            return Ok(await _db.products.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDto>> GetStudent(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer producto con id {id}");
                return BadRequest();
            }
            var producto = await _db.products.FirstOrDefaultAsync(s => s.productId == id);

            if (producto == null)
            {
                _logger.LogError($"Error al traer producto con id {id}");
                return NotFound();
            }

            return Ok(producto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductDto>> AddStudent([FromBody] ProductCreateDto productoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _db.products.FirstOrDefaultAsync(s => s.productName.ToLower() ==  productoDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El producto con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (productoDto == null)
            {
                return BadRequest(productoDto);
            }

            products modelo = new()
            {
                productName = productoDto.Name
            };

            await _db.products.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetStudent", new { id = modelo.productId }, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var student = await _db.products.FirstOrDefaultAsync(s => s.productId == id);

            if (student == null)
            {
                return NotFound();
            }

            _db.products.Remove(student);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateStudents(int id, [FromBody] ProductUpdateDto productDto)
        {
            if (productDto == null || id != productDto.productId)
            {
                return BadRequest();
            }

            products modelo = new()
            {
                productId = productDto.productId,
                productName = productDto.productName
            };

            _db.products.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialStudent([Required] int id, [Required] JsonPatchDocument<ProductUpdateDto> patchDto)
        {
            var products = await _db.products.AsNoTracking().FirstOrDefaultAsync(s => s.productId == id);

            if (products == null) return BadRequest();

            var studentDto = new ProductUpdateDto
            {
                productId = products.productId,
                productName = products.productName
            };

            patchDto.ApplyTo(studentDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var modelo = new products
            {
                productId = studentDto.productId,
                productName = studentDto.productName
            };

            _db.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}

