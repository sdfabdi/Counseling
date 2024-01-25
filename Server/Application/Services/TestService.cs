using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Services
{
    public class TestService : ITestService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public TestService(DataContext dataContext, IMapper mapper) 
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<TestSubmitDTO> CreateTest(TestSubmitDTO test)
        {
            if (test == null)
            {
                throw new InvalidOperationException("Test data is null.");
            }
            var submitTest = _mapper.Map<Test>(test);
            _dataContext.Tests.Add(submitTest);
            await _dataContext.SaveChangesAsync();

            return test;
        }
        
        public async Task<IEnumerable<TestReadDTO>> GetAllTests()
        {
            var tests = await _dataContext.Tests
                .Include(t => t.Category)
                .ToListAsync();
                foreach ( var test in tests)
                {
                    test.Answers = await _dataContext.Answers
                                            .Where(a => a.CategoryID == test.CategoryID)
                                            .ToListAsync();
                }
            if (tests == null) throw new InvalidOperationException();
            var finalTests = _mapper.Map<IEnumerable<TestReadDTO>>(tests);
            return finalTests;
        }
        public async Task<IEnumerable<TestReadDTO>> GetTestsByCategory(int categoryId)
        {
            var tests = await _dataContext.Tests
                .Where(t => t.CategoryID == categoryId)
                .Include(t => t.Category)
                .ToListAsync();
                foreach ( var test in tests)
                {
                    test.Answers = await _dataContext.Answers
                                .Where(a => a.CategoryID == test.CategoryID)
                                .ToListAsync();
                }
            var finalTests = _mapper.Map<IEnumerable<TestReadDTO>>(tests);
            if (tests == null || tests.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return finalTests;
        }
        public TestReadDTO GetTestById(int testId)
        {
            var test = _dataContext.Tests
                .Where(t => t.TestID == testId)
                .Include(t => t.Category)
                .FirstOrDefault();
            test.Answers = _dataContext.Answers
                        .Where(a => a.CategoryID == test.CategoryID)
                        .ToList();
            var finalTest = _mapper.Map<TestReadDTO>(test);
            if (test == null)
            {
                throw new InvalidOperationException();
            }

            return finalTest;
        }

        public async Task<IEnumerable<MBTIReadDTO>> GetMbtiTest()
        {
            var mbtiTests = await _dataContext.MBTIs
                .Include(t => t.Category)
                .ToListAsync();
            if (mbtiTests == null)
            {
                throw new InvalidOperationException();
            }
            var res = _mapper.Map<IEnumerable<MBTIReadDTO>>(mbtiTests);
            return res;
        }
    }
}
