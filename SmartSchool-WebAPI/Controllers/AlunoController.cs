using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController: ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Mario");
        }
    }
}