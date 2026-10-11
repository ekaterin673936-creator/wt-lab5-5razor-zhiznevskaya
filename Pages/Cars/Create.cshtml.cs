using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_zhiznevskaya.Data;
using wt_lab5_5razor_zhiznevskaya.Models;

namespace wt_lab5_5razor_zhiznevskaya.Pages.Cars;

public class CreateModel : PageModel
{
    [BindProperty]
    public Car Car { get; set; } = new();

    public void OnGet()
    {
        // Просто показываем пустую форму
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Автоматически присваиваем новый Id
        Car.Id = CarStore.Cars.Any()
            ? CarStore.Cars.Max(x => x.Id) + 1
            : 1;

        CarStore.Cars.Add(Car);

        return RedirectToPage("./Index");
    }
}