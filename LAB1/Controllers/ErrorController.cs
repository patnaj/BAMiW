using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class ErrorController : Controller
{
    // Bezpieczna wersja – ogólny komunikat
    public IActionResult Index(int code, string path)
    {
        // http://localhost:5001/this-page-does-not-exist%3Cscript%3Ealert(%27404%27)%3C/script%3E
        ViewBag.Code = code;
        ViewBag.Path = path;   // UWAGA: dane od użytkownika!
        return View();
    }

    // NIEBEZPIECZNA wersja – pokazuje szczegóły wyjątku
    public IActionResult Details()
    {
        var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
        if (feature != null)
        {
            // CELOWO: przekazujemy pełny wyjątek do widoku
            ViewBag.Path = feature.Path;
            ViewBag.Error = feature.Error.ToString(); // stack trace, szczegóły SQL itd.
        }

        return View();
    }
}
