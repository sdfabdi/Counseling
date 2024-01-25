using Application.Interfaces;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {

        private readonly IAnswerService _answerService;
        public AnswersController(IAnswerService answerService)
        {

            _answerService = answerService;
        }
        // POST: api/Answers/CreateAnswer
        [HttpPost("CreateAnswer")]
        public async Task<ActionResult<AnswerSubmitDTO>> CreateAnswer([FromBody] AnswerSubmitDTO answer)
        {
            try
            {
                var asnswerSubmitDto = await _answerService.CreateAnswer(answer);
                return Ok(asnswerSubmitDto);
            }
            catch (InvalidOperationException)
            {

                return BadRequest("Cannot Create a new Answer");
            }
        }
        // GET: api/Answers/GetAnswersByCategory/1
        [HttpGet("GetAnswersByCategory/{categoryId}")]
        public async Task<ActionResult<IEnumerable<AnswerReadDTO>>> GetAnswersByCategory(int categoryId)
        {
            try
            {
                var answer = await _answerService.GetAnswersByCategory(categoryId);
                return Ok(answer);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }
    }
}
