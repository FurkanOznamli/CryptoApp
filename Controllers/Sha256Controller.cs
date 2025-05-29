using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme.Controllers
{
    public class Sha256Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string plainText, IFormFile uploadedFile)
        {
            ViewBag.PlainText = plainText;

            if (!string.IsNullOrEmpty(plainText))
            {
                using var sha256 = SHA256.Create();
                var bytes = Encoding.UTF8.GetBytes(plainText);
                var hash = sha256.ComputeHash(bytes);

                ViewBag.HashResult = ByteArrayToHex(hash);
            }
            else if (uploadedFile != null && uploadedFile.Length > 0)
            {
                using var sha256 = SHA256.Create();
                using var stream = uploadedFile.OpenReadStream();
                var hash = sha256.ComputeHash(stream);

                ViewBag.HashResult = ByteArrayToHex(hash);
                ViewBag.FileName = uploadedFile.FileName;
            }
            else
            {
                ViewBag.Error = "Lütfen metin girin veya bir dosya yükleyin.";
            }

            return View();
        }

        private string ByteArrayToHex(byte[] hash)
        {
            var sb = new StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}
