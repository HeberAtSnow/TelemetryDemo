using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Refit;
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundWebFrontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IJokePersonFacade jokePersonFacade;

        public IndexModel(ILogger<IndexModel> logger, IJokePersonFacade jokePersonFacade)
        {
            _logger = logger;
            this.jokePersonFacade = jokePersonFacade ?? throw new ArgumentNullException(nameof(jokePersonFacade));
        }

        public async Task OnPost(int idnum)
        {

            Num = DateTime.Now.Ticks;
            ThePersonJoke = await jokePersonFacade.GetPersonJokeAsync(idnum);

        }
        public async Task OnGet()
        {
            Num = DateTime.Now.Ticks;
            ThePersonJoke = await jokePersonFacade.GetPersonJokeAsync(5);
        }

        public long Num { get; set; }
        public PersonJoke ThePersonJoke { get; set; }
    }
}
