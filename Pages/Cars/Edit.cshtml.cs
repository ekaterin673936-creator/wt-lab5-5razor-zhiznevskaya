using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_zhiznevskaya.Data;
using wt_lab5_5razor_zhiznevskaya.Models;

namespace wt_lab5_5razor_zhiznevskaya.Pages.Cars;

public class EditModel : PageModel
{
    [BindProperty]
    public Car Car { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var existing = CarStore.Cars.FirstOrDefault(c => c.Id == id);
        if (existing == null)
        {
            return NotFound();
        }

        Car = existing;
        return Page();
    }

    public IActionResult OnPost(int id)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var existing = CarStore.Cars.FirstOrDefault(c => c.Id == id);
        if (existing == null)
        {
            return NotFound();
        }

        existing.Brand = Car.Brand;
        existing.Model = Car.Model;
        existing.Year = Car.Year;
        existing.PricePerDay = Car.PricePerDay;
        existing.IsAvailable = Car.IsAvailable;

        return RedirectToPage("./Index");
    }
}