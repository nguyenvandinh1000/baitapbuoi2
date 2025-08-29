using Microsoft.AspNetCore.Mvc;
using System.text.Encodings.Web;


namespace baitapbuoi2.Controllers
{
    public class HelloworldController : Controller
    {
        public string Index()
        {
            return "this is my default action...";
        }
        public string Welcom()
        {
            return "this is welcom action method...";
        }
    }
}
