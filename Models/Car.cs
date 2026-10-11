using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_zhiznevskaya.Models;

public class Car
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Укажите марку")]
    [StringLength(50)]
    public string Brand { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите модель")]
    [StringLength(50)]
    public string Model { get; set; } = string.Empty;

    [Range(1900, 2100, ErrorMessage = "Некорректный год")]
    public int Year { get; set; }

    [Range(0.01, 1000000, ErrorMessage = "Цена должна быть больше 0")]
    public decimal PricePerDay { get; set; }

    public bool IsAvailable { get; set; } = true;
}