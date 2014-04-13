using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Auth;
using Auth.Models;
using System.Web.Security;
using FormsAuthJSONPDemo2.Filters;

namespace FormsAuthJSONPDemo2.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/login/{name}/{password}")]
        [HttpGet]
        public ViewUser Login(string Name, string Password)
        {
            var user = UserData.FindUser(Name, Password);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Name, false);
            }
            return user;
        }

        [DemoAuth]
//        [Authorize]
        [Route("api/auth")]
        [HttpGet]
        public bool CheckAuth()
        {
            return true;
        }

        // GET api/auth
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/auth/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/auth
        public void Post([FromBody]string value)
        {
        }

        // PUT api/auth/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/auth/5
        public void Delete(int id)
        {
        }
    }
}
