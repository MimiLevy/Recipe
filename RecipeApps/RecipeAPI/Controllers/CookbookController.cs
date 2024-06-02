using Microsoft.AspNetCore.Mvc;
using RecipeAppsSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbook> Get()
        {
            return new bizCookbook().GetList();
        }

        [HttpGet("{id:int:min(1)}")]
        public bizCookbook Get(int id)
        {
            bizCookbook c = new();
            c.Load(id);
            return c;
        }
    }
}
