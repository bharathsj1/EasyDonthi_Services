namespace EasyDonthi.Controllers
{
    using System.Web.Http;
    using Business;

    //[Authorize]
    [AllowAnonymous, RoutePrefix("api/Values")]
    public class ValuesController : ApiController
    {
        [Route("ValidateUser")]
        [HttpGet]
        public bool ValidateUser(string userName, string password)
        {
            UserManager userManager = new UserManager();
            bool result = userManager.ValidateUser(userName, password);
            return result;
        }

        [Route("ValidateUser")]
        [HttpGet]
        public bool AddUser(string userName, string password)
        {
            UserManager userManager = new UserManager();
            bool result = userManager.AddUser(userName, password);
            return result;
        }
    }
}
