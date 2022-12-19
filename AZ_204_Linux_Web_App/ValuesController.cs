using AZ_204_Linux_Web_App.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_204_Linux_Web_App
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private AppDBContext _appDBContext;

        public ValuesController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet("GetData")]
        public IActionResult GetData()
        {
            try
            {
                return Ok("Returned From CICD");
                //return Ok(_appDBContext.Course.ToList());
            }
            catch (Exception Ex)
            {
                return StatusCode(500, string.Join(",",Ex.Message, Ex.StackTrace));
            }
        }
    }
}
