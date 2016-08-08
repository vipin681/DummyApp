using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BAL;
using System.Web.Http.Cors;

namespace Dummy.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
       // [HttpPost]
      
        [HttpPost]
        public HttpResponseMessage Savedata(User user)
        {
            // User ModelUser = new User();
            UserBLL user1 = new UserBLL();
            user1.AddUser(user);
            return Request.CreateResponse(HttpStatusCode.OK, "Record Inserted Successfully.");
        }
        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/User/5
        public void Delete(int id)
        {

        }
    }
}
