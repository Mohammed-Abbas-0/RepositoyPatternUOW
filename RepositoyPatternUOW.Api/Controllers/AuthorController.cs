using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.IRepository;
using RepositoryPatternWithUOW.Core.Models;
using RepositoryPatternWithUOW.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoyPatternUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IGenericRepository<Author> _authorRepository;
        public AuthorController(IGenericRepository<Author> authorRepository) => _authorRepository = authorRepository;
        
        [HttpGet]
        public async Task<IActionResult> GetAuthorDetailById(int Id)
        {
            return Ok(await _authorRepository.FetchDetailsById(Id));
        }
        [HttpGet("FindByAuthorName")]
        public IActionResult FindAuthorName()
        {
            return Ok(_authorRepository.Find(idx=> idx.AuthorName == "Hakem"));
        }

    }
}
