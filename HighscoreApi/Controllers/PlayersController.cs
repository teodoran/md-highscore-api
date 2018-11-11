﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HighscoreApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase {
        // GET api/players
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get () {
            return new string[] { "dalek", "idris" };
        }

        // GET api/players/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST api/players
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/players/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}