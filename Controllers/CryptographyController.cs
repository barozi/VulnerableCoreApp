using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace VulnerableCoreApp.Controllers {

    public class CryptographyController : Controller
    {
        public IActionResult Hash(string message)
            {
                var sourceBytes = ASCIIEncoding.ASCII.GetBytes(message);
                var hash = new MD5CryptoServiceProvider().ComputeHash(sourceBytes);

                return View();
            }
    }

}
