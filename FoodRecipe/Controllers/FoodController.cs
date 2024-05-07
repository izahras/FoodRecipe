using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodRecipe.Entities;
using FoodRecipe.Data;
using Microsoft.EntityFrameworkCore;

namespace FoodRecipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly DataContext _context;
        public FoodController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Food>>> GetFoods()
        {
            var foods = await _context.Foods.ToListAsync();
            return Ok(foods);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Food>>> GetFood(int id)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food == null)
                return NotFound("این غذا موجود نیست");
            return Ok(food);
        }

        [HttpPost]
        public async Task<ActionResult<List<AlergicMaterial>>> AddAlergicMaterials([FromBody]AlergicMaterial input)
        {
            _context.AlergicMaterials.Add(input);
            await _context.SaveChangesAsync();
            return Ok(await GetFoods());
        }
    }
}
