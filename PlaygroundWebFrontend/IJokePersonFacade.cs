using Refit;
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundWebFrontend
{
    public interface IJokePersonFacade
    {
        [Get("/JokePersonFacade/{id}")]
        Task<PersonJoke> GetPersonJokeAsync(int id);
    }
}
