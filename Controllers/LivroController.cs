using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Mvc;
using JobC.Data;
using Api.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/livro")] 

    public class LivroController : ControllerBase
    {

       private DataContext _context;

       public LivroController(DataContext context)
       {

       }
        ///api/route/create
        [Route ("create")]
        [HttpPost]
        public  Livro Create (Livro livro) 
        {
           _context.Livros.Add(livro);
            return livro;
             
        }
        public Livro Get()
        {
            return new Livro();
        }

    }
}