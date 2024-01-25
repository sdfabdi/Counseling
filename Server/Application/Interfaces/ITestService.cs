using Domain.DTOs;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITestService
    {
        public Task<TestSubmitDTO> CreateTest(TestSubmitDTO test);
        public Task<IEnumerable<TestReadDTO>> GetAllTests();
        public Task<IEnumerable<TestReadDTO>> GetTestsByCategory(int categoryId);
        public TestReadDTO GetTestById(int testId);
        public Task<IEnumerable<MBTIReadDTO>> GetMbtiTest();
    }
}
