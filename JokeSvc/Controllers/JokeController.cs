using Microsoft.AspNetCore.Mvc;
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeSvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : Controller
    {
        [HttpGet]
        public String GetJoke()
        {
            return "Knock Knock";
        }

        [HttpGet("{id:int}")]
        public Joke GetJokeByID(int id)
        {
            Joke j = new Joke
            {
                ID = id, JokeText = "Knock Knock"
            };
            return j;
        }
    }
}
