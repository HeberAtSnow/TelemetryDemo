using Microsoft.AspNetCore.Mvc;
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        public String Get()
        {
            return "John Jingkle Gingerhimer Schmidt";
        }

        [HttpGet("{id:int}")]
        public Person GetByID(int id)
        {
            return new Person
            {
                ID = id,
                FirstName = "John Jacob",
                LastName = "GingleHeimer Schmidt"
            };

        }
    }


}
