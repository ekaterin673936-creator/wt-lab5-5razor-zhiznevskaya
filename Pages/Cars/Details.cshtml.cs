using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_zhiznevskaya.Data;
using wt_lab5_5razor_zhiznevskaya.Models;

namespace wt_lab5_5razor_zhiznevskaya.Pages.Cars;

public class DetailsModel : PageModel
{
    public Car? Car { get; set; }

    public IActionResult OnGet(int id)
    {
        Car = CarStore.Cars.FirstOrDefault(c => c.Id == id);

        if (Car == null)
        {
            return NotFound();
        }

        return Page();
    }
}