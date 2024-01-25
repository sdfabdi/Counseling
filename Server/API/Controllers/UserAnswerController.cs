using Application.Interfaces;
using Domain.DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnswerController : ControllerBase
    {
        private readonly IUserAnswerService _UserAnswerService;

        public UserAnswerController(IUserAnswerService userAnswerService)
        {
            _UserAnswerService = userAnswerService;
        }

        // POST: api/UserAnswer/CreateUserAnswer
        [HttpPost("CreateUserAnswer")]
        public async Task<ActionResult<UserAnswerSubmitDTO>> CreateUserAnswer([FromBody] UserAnswerSubmitDTO userAnswerSubmitDTO)
        {
            try
            {
                var submitUserAnswer = await _UserAnswerService.CreateUserAnswer(userAnswerSubmitDTO);
                return Ok(submitUserAnswer);
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE: api/UserAnswer/DeleteUserAnswer/{id}
            [HttpDelete("DeleteUserAnswer/{id}")]
            public async Task<ActionResult> DeleteUserAnswer(int id)
            {
                try
                {
                    await _UserAnswerService.DeleteUserAnswer(id);
                    return Ok();
                }
                catch
                {
                    return NotFound();
                }
            }
    }
}

