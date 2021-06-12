using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiTextiles.Context;

namespace ApiTextiles.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TextilesController : ControllerBase
    {
        private readonly AppDbContext context;
        public TextilesController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            //Error handling Try-catch
            return Ok(context.textiles.ToList());
        }

    }
}
