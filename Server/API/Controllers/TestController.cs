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
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        // POST: api/Test/CreateTest
        [HttpPost("CreateTest")]
        public async Task<ActionResult<TestSubmitDTO>> CreateTest([FromBody] TestSubmitDTO test)
        {
            try
            {
                var submitTest = await _testService.CreateTest(test);
                return Ok(submitTest);
            }
            catch (InvalidOperationException)
            {
                return BadRequest("Cannot Create a new test");
            }
        }
        // GET: api/Test
        [HttpGet("GetAllTests")]
        public async Task<ActionResult<IEnumerable<TestReadDTO>>> GetAllTests()
        {
            try
            {
                var res = await _testService.GetAllTests();
                return Ok(res);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }

        // GET: api/Test/GetTestByCategory/5
        [HttpGet("GetTestByCategory/{categoryId}")]
        public async Task<ActionResult<IEnumerable<TestReadDTO>>> GetTestsByCategory(int categoryId)
        {
            try
            {
                var res = await _testService.GetTestsByCategory(categoryId);
                return Ok(res);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }

        // GET: api/Test/GetTestById/1
        [HttpGet("GetTestById/{testId}")]
        public async Task<ActionResult<TestReadDTO>> GetTestById(int testId)
        {
            try
            {
                var res =  _testService.GetTestById(testId);
                return Ok(res);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }
        // GET: api/Test/GetMbti
        [HttpGet("GetMbti")]
        public async Task<ActionResult<IEnumerable<MBTI>>> GetMbtiTest()
        {
            try
            {
                var res = await _testService.GetMbtiTest();
                return Ok(res);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }
    }
}
