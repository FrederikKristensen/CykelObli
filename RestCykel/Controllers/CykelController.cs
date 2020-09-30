using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CykelObli;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestCykel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CykelController : ControllerBase
    {
        // Data
        private static List<CykelClass.Cykel> _data = new List<CykelClass.Cykel>()
        {
            new CykelClass.Cykel(1, "Red", 300, 24),
            new CykelClass.Cykel(2, "Blue", 240, 12),
            new CykelClass.Cykel(3, "Green", 200, 6)
        };

        // GET: api/Cykel
        [HttpGet]
        public IEnumerable<CykelClass.Cykel> Get()
        {
            return _data;
        }

        // GET: api/Cykel/5
        [HttpGet("{id}")]
        public CykelClass.Cykel Get(int id)
        {
            return _data.Find(c => c.Id == id);
        }

        // POST: api/Cykel
        [HttpPost]
        public void Post([FromBody] CykelClass.Cykel value)
        {
            _data.Add(value);
        }

        // PUT: api/Cykel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // coming
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CykelClass.Cykel cykel = Get(id);
            if (cykel != null)
            {
                _data.Remove(cykel);
            }
        }
    }
}
