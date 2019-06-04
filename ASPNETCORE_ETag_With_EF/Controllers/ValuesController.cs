using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        public MemoryContext Database { get; set; }
        public ValuesController(MemoryContext db) {
            Database = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Article>> Get() {
            return Database.Articles;
        }

        [HttpPost]
        public void Post([FromBody] string value) {
            Database.Articles.Add(new Article() { Time = DateTime.Now });
            Database.SaveChanges();
        }
    }
}
