using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;

namespace SocialManager.Controllers
{
    using System.Threading.Tasks;
    using System.Web.UI.WebControls;

    using SocialManager.Models;

    /// <summary>
    /// The facebook controller.
    /// </summary>
    [Authorize]
    [FacebookAccessTokenAttribute]
    public class FacebookController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
   
        /// </returns>
        public async Task<ActionResult> Index()
        {
            var access_token = HttpContext.Items["access_token"].ToString();
            if (access_token != null)
            {
                try
                {
                    var appsecret_proof = access_token.GenerateAppSecretProof();
                    var fb = new FacebookClient(access_token);
                }
            }
            return View();
        }

    }

    /// <summary>
    /// The facebook access token attribute.
    /// </summary>
    public class FacebookAccessTokenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
//            ApplicationUserManager _userManager = filterContext.HttpContext.GetOwinContext()

        }
    }
}
