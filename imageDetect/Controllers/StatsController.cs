﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using imageDetect.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace imageDetect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        public StatsController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> AnalizeImage([FromForm] NewImageDTO image)
        {
            var file = image.File;


            return Ok();
        }
    }
}