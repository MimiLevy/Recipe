using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppsSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisineTypeController : ControllerBase
    {
        [HttpGet]
        public List<bizCuisineType> Get()
        {
            return new bizCuisineType().GetList(false);
        }
    }
}
