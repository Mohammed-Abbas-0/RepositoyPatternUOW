using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.IRepository;
using RepositoryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoyPatternUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IGenericRepository<Book> _bookRepositor;
        public BookController(IGenericRepository<Book> bookRepository) => _bookRepositor = bookRepository;
        [HttpGet("FindBook")]
        public IActionResult FindBook()
        {
            return Ok(_bookRepositor.Find(idx=>idx.BookTitle == "Eco History", new[] { "Authors" }));
        }

        [HttpGet("FindAllBook")]
        public async Task<IActionResult> GetAllBookAppliesToCondition()
        {
            List<int> BookIds = new List<int>{ 1,2,3};
            return Ok(await _bookRepositor.FindAllData(idx=> BookIds.Contains(idx.Id),new[] { "Authors" },1,1 ));
        }
    }
}
