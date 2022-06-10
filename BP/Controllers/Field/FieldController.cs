using BP.Services.Field;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BP.Controllers.Field
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class FieldController : ControllerBase
    {

        private readonly IFieldService _fieldService;
        public FieldController(IFieldService fieldService)
        {
            _fieldService = fieldService;
        }

        [HttpGet("[action]")]
        public IActionResult GetFields()
        {
            try
            {
                var fields = _fieldService.GetListOfFields();
                return Ok(fields);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("[action]")]
        public IActionResult GetFieldsByCity(string city)
        {
            try
            {
                var fields = _fieldService.GetFieldsByCity(city);
                return Ok(fields);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("[action]")]
        public IActionResult GetFieldsBySportNames(string sportTypeNames)
        {
            try
            {
                var fields = _fieldService.GetFieldsBySportNames(sportTypeNames);
                return Ok(fields);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
