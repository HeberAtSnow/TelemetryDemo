using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using SharedLibrary;

namespace Facade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokePersonFacade : Controller
    {
        private readonly IConfiguration configuration;

        public JokePersonFacade(IConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        [HttpGet("{id:int}")]
        public async Task<PersonJoke> Get(int id)
        {
            var httpClient = new HttpClient();
            var joke = await httpClient.GetFromJsonAsync<Joke>($"{configuration["JOKE_SERVICE"]}/joke/{id}");
            var person = await httpClient.GetFromJsonAsync<Person>($"{configuration["PERSON_SERVICE"]}/person/{id}");
            return new PersonJoke
            {
                ID = id,
                JokeText = joke.JokeText,
                Person = person
            }; 
        }
    }

}
