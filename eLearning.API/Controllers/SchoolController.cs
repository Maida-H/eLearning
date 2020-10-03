using eLearning.Domain;
using eLearning.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
// using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;


namespace eLearning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : BaseController
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(Unit.Schools.Get().ToList());
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult Get(int id)
        {
            try
            {
                School school = Unit.Schools.Get(id);

                if (school == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(school);
                }
            }

            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
