using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleAPI.Data;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly appdbcontext _db;

        public NameController(appdbcontext db)
        {
            _db = db;
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<NameSample>>> GetNames()
        {
            return await _db.Samples.ToListAsync();
        }

        [HttpPost]
        [Authorize]
        public async Task<string> PostName(NameSample nameSample)
        {
            _db.Samples.Add(nameSample);
            await _db.SaveChangesAsync();
            return "";
        }
    }
}
