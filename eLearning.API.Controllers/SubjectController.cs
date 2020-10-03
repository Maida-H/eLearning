using eLearning.Domain;
using eLearning.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace eLearning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : BaseController
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(Unit.Subjects.Get().ToList());
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult Get(int id)
        {
            try
            {
                Subject subject = Unit.Get.Subjects(id);

                if (subject == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(subject);
                }
            }

            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
