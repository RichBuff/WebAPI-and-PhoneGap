using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FormsAuthJSONPDemo2.Filters
{
    public class DemoAuthAttribute : AuthorizeAttribute 
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext filterContext)
        {
            //base.OnAuthorization(filterContext);

            if (base.IsAuthorized(filterContext) == false)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

        }
    }
}