using Job_Portal_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly JobDBContext _dbContext;

        public FormController(JobDBContext dbContext)
        {
            _dbContext = dbContext;
        }

      
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Form form)
        {
            if (form == null)
            {
                return BadRequest("Inserted form data is invalid.");
            }

            try
            {
                _dbContext.Form.Add(form);
                await _dbContext.SaveChangesAsync();

                return CreatedAtAction("GetFormById", new { id = form.CandidateId }, form);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
        
       // [HttpGet]
       // public async Task<ActionResult<IEnumerable<Form>>> getAppliedJobs()
       // {
       //     return Ok(_dbContext.Form.Include(x=>x.jobId).ToList());
        // }

    }
}
