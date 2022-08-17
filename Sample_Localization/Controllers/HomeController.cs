using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Sample_Localization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        public HomeController(IStringLocalizer<SharedResource> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_stringLocalizer.GetString("Hello").Value +$"{DateTime.Now}");
        }
    }
}
