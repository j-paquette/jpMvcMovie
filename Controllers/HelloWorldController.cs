using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int ID = 1)
    {
        //HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}