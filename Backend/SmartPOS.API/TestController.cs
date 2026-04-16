using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPOS.Persistence.AppDbContext;

namespace SmartPOS.API
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly SmartPOSDbContext _context;

        public TestController(SmartPOSDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("DB Connected");
        }
    }
}
