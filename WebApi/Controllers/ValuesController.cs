using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        StudentEntities db = new StudentEntities();
        public IEnumerable<Student_Details> Get()
        {
            return db.Student_Details.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "values";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
