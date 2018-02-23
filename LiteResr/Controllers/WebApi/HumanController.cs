using LiteResr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LiteResr.Controllers.WebApi
{
    public class HumanController : ApiController
    {
        //http://localhost:1610/api/Human 
        [HttpGet]
        public IEnumerable<Human> Get()
        {
            List<Human> Concubines = new List<Human>();
            Concubines.Add(new Human { Name = "Natasha", Age = 27 });
            Concubines.Add(new Human { Name = "Nastya", Age = 22  });
            return Concubines;
        }

        //http://localhost:1610/api/Human/37
        [HttpGet]
        public Human Get(int id)
        {
            return new Human { Age = id, Name = "CurrentNameSlave" };
        }

        // POST
        // Body => { "Name": "Natasha", "Age": 27  }
        // Content-Type => application/json

        public string Post(Human newSlave)
        {
            /*
             Add to DB.
             */
            return "New female slave was created successfully!";
        }
    }
}
