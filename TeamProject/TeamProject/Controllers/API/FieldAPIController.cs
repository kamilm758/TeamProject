using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormGenerator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TeamProject.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldAPIController : ControllerBase
    {
        private readonly FormGeneratorContext _context;

        public FieldAPIController(FormGeneratorContext context)
        {
            _context = context;
        }

        // GET: api/FieldAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Field>>> GetField()
        {
            return await _context.Field.ToListAsync();
        }
    }
}