using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab1Zodiac.Models;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Year { get; set; }

    [TempData]
    public string? ZodiacSign { get; set; }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            ZodiacSign = Utils.GetZodiac(Year).ToLower();

        }
        return Page();
    }
}