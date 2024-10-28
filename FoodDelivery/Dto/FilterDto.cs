using System.ComponentModel.DataAnnotations;
using FoodDelivery.Enums;

namespace FoodDelivery.Dto;

/// <summary>
/// Модель фильтра заказа.
/// </summary>
public class FilterDto
{
    /// <summary>
    /// Район заказа.
    /// </summary>
    [Required(ErrorMessage = "Укажите район доставки")]
    public Region CityDistrict { get; set; }
    
    /// <summary>
    /// Время первого заказа.
    /// </summary>
    [Required(ErrorMessage = "Укажите время первой доставки")]
    [RegularExpression(@"\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}", ErrorMessage = "Дата должна быть в формате yyyy-MM-dd HH:mm:ss")]
    public string FirstDeliveryDateTime { get; set; }

    public DateTime GetFirstDeliveryDateTimeParsed()
    {
        return DateTime.ParseExact(FirstDeliveryDateTime, "yyyy-MM-dd HH:mm:ss", null);
    }
}