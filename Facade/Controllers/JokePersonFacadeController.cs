using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using SharedLibrary;
using Microsoft.Extensions.Logging;

namespace Facade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokePersonFacadeController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<JokePersonFacadeController> logger;

        public JokePersonFacadeController(IConfiguration configuration, ILogger<JokePersonFacadeController> logger)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        [HttpGet("{id:int}")]
        public async Task<PersonJoke> Get(int id)
        {
            var httpClient = new HttpClient();
            var joke = await httpClient.GetFromJsonAsync<Joke>($"{configuration["JOKE_SERVICE"]}/joke/{id}");
            var person = await httpClient.GetFromJsonAsync<Person>($"{configuration["PERSON_SERVICE"]}/person/{id}");
            logger.LogInformation("Facade Called Get on Joke and Get on person {id} {result}", id, person);
            logger.LogError("WhyNotInDB?");
            return new PersonJoke
            {
                ID = id,
                JokeText = joke.JokeText,
                Person = person
            }; 
        }
    }

}
