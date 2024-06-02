using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppsSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<BizRecipe> Get()
        {
            return new BizRecipe().GetList();
        }

        [HttpGet("{id:int:min(1)}")]
        public BizRecipe Get(int id)
        {
            BizRecipe r = new();
            r.Load(id);
            return r;
        }
    }
}
