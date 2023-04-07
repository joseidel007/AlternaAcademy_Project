using alterna_academy_project.Data;
using alterna_academy_project.Models;
using alterna_academy_project.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alterna_academy_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ApplicationDbContext _db;

        public LoginController(ILogger<LoginController> logger, ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LoginDto>> GetLogins() {
            return Ok(_db.Logins.ToList());
        }

        [HttpPost]
        public async Task<ActionResult> AddLogin(Login login)
        {
            _db.Logins.Add(login);
            await _db.SaveChangesAsync();
            return Ok();

        }
    }
}
