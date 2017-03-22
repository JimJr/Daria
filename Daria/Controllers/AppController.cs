namespace Daria.Controllers
{
    using System.Web.Mvc;

    public class AppController : Controller
    {
        private bool _isAuthenticated;

        public AppController()
        {
            this._isAuthenticated = false;
        }

        public ActionResult Index()
        {
            if (!this._isAuthenticated)
            {
                this.Response.Redirect("~/App/Login");
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}