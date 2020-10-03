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
    public class ProfessorController : BaseController
    {
        [HttpGet]
        
        public IActionResult Get()
        {
            return Ok(Unit.Professors.Get().ToList());
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult Get(int id)
        {
            try
            {
                Professor professor = Unit.Professors.Get(id);
                
                if (professor == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(professor);
                }
            }

            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    } 
}
