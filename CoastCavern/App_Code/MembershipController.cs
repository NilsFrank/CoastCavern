using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;

namespace CoastCavern
{

    public class MembershipController : SurfaceController
    {
        [HttpGet]
        [ActionName("MemberLogin")]
        public ActionResult Index()
        {
            return PartialView("LoginForm", new LoginViewModel());
        }

        [HttpPost]
        [ActionName("MemberLogin")]
        public ActionResult Validate(LoginViewModel model)
        {
            if (Membership.ValidateUser(model.Login, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Login, model.RememberMe);
                return Redirect("/");
            }
            TempData["Status"] = "Invalid Log-in Credentials";
            return RedirectToCurrentUmbracoPage() ;
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }

}
