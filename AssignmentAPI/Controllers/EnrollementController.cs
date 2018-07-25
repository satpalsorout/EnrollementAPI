using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AssignmentAPI.Models;
using Microsoft.AspNetCore.Cors;

namespace AssignmentAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Enrollement")]
    public class EnrollementController : Controller
    {
        // GET: api/Enrollement
        [HttpGet]
        public IEnumerable<EnrollementUser> Get()
        {
            return Enrollement.lstEnrollement;
        }

        // GET: api/Enrollement/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Enrollement
        [HttpPost]
        public bool Post([FromBody]EnrollementUser enrollementUser)
        {
            enrollementUser.id = Enrollement.lstEnrollement.Count()+1;
            Enrollement.lstEnrollement.Add(enrollementUser);
            return true;
        }
        
        // PUT: api/Enrollement/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]EnrollementUser enrollementUser)
        {
            EnrollementUser existingUser =  Enrollement.lstEnrollement.AsEnumerable().Where(x => x.id.Equals(id)).FirstOrDefault();
            if(existingUser!=null)
            {
                Enrollement.lstEnrollement.Remove(existingUser);
                Enrollement.lstEnrollement.Add(enrollementUser);
            }
            
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (Enrollement.lstEnrollement.Where(x => x.id.Equals(id)).Count() > 0)
            {

                EnrollementUser enrollementUser = Enrollement.lstEnrollement.AsEnumerable().Where(x => x.id.Equals(id)).FirstOrDefault();
                Enrollement.lstEnrollement.Remove(enrollementUser);
            }
        }
    }
}
