using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : Controller
    {
        private readonly LibraryContext LibraryContext;

        public LibraryController(LibraryContext DBContext)
        {
            LibraryContext = DBContext;
        }

        [HttpPost("Book")]
        public IActionResult AddBook([FromBody]Book book)
        {
            if(!ModelState.IsValid || book.Id == 0) { return BadRequest();  }

            LibraryContext.Add(book);
            LibraryContext.SaveChanges();

            return StatusCode(200);
        }

        [HttpPost("Loan")]
        public IActionResult AddLoan([FromBody]Loan loan)
        {
            if (!ModelState.IsValid || loan.Id == 0) { return BadRequest(); }

            LibraryContext.Add(loan);
            LibraryContext.SaveChanges();

            return StatusCode(200);
        }
    }
}