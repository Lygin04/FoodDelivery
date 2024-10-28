using System.ComponentModel.DataAnnotations;
using FoodDelivery.Enums;

namespace FoodDelivery.Dto;

/// <summary>
/// Модель для заполнения полей заказа.
/// </summary>
public class OrderDto
{
    /// <summary>
    /// Вес заказа в килограммах
    /// </summary>
    [Required(ErrorMessage = "Введите вес заказа в кг")]
    [Range(0.001, 100000, ErrorMessage = "Вес не должен превышать 100000 кг")]
    public double Weight { get; set; }
    
    /// <summary>
    /// Район заказа
    /// </summary>
    [Required(ErrorMessage = "Укажите район заказа")]
    public Region CityDistrict { get; set; }
}