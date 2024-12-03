using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YourProject.Models; // Movie modelinin bulunduğu namespace


namespace MyWebApp.Pages;

public class MoviesModel : PageModel
{
    private readonly ILogger<MoviesModel> _logger;

    public MoviesModel(ILogger<MoviesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}