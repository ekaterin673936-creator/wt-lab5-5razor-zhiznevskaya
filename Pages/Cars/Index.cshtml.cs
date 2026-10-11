using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_zhiznevskaya.Data;
using wt_lab5_5razor_zhiznevskaya.Models;

namespace wt_lab5_5razor_zhiznevskaya.Pages.Cars;

public class IndexModel : PageModel
{
    public List<Car> Cars { get; set; } = new();

    public void OnGet()
    {
        Cars = CarStore.Cars;
    }
}