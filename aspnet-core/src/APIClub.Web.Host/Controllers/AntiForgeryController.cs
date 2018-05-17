using Microsoft.AspNetCore.Antiforgery;
using APIClub.Controllers;

namespace APIClub.Web.Host.Controllers
{
    public class AntiForgeryController : APIClubControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
