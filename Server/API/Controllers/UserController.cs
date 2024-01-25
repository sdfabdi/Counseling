using Application.Interfaces;
using Domain.DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    // POST: api/User/CreateUser
    [HttpPost("CreateUser")]
    public async Task<ActionResult<UserSubmitDTO>> CreateUser([FromBody] UserSubmitDTO userSubmitDTO)
    {
        try
            {
                var user = await _userService.CreateUser(userSubmitDTO);
                return Ok(user);
            }
            catch (InvalidOperationException)
            {
                return BadRequest("Cannot Create a new user");
            }
    }

        // DELETE: api/User/DeleteUser/{id}
        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            try
            {
                await _userService.DeleteUser(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

}