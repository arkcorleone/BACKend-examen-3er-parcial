using backend_crud_examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_crud_examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public ProductoController( AplicationDbContext context)
        {
            _context= context;
        }



        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                Thread.Sleep(3000);
                var listProductos = await _context.Productos.ToListAsync();
                return Ok(listProductos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("(id)")]
        public async  Task<ActionResult> Get(int id)
        {
            try
            {
                var Producto = await _context.Productos.FindAsync(id);

                if (Producto == null)

                {
                    return NotFound();
                }

                
                return Ok(Producto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
