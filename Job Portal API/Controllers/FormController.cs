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

        // POST: api/Form
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Form form)
        {
            if (form == null)
            {
                // If the form data is invalid, return a 400 Bad Request.
                return BadRequest("Inserted form data is invalid.");
            }

            try
            {
                _dbContext.Form.Add(form);
                await _dbContext.SaveChangesAsync();

                // Return a 201 Created status with the newly created form data.
                return CreatedAtAction("GetFormById", new { id = form.CandidateId }, form);
            }
            catch (Exception ex)
            {
                // If an exception occurs during the process, return a 500 Internal Server Error with an error message.
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        // Additional endpoints can be added here to retrieve or manipulate form data.
        // Example:
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Form>>> getAppliedJobs()
        // {
        //     return Ok(_dbContext.Form.Include(x=>x.jobId).ToList());
        // }

    }
}
