using FoodDelivery.Enums;

namespace FoodDelivery.Entities;

/// <summary>
/// Заказ
/// </summary>
public class Order
{
    /// <summary>
    /// Номер заказа
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Вес заказа в килограммах
    /// </summary>
    public double Weight { get; set; }
    
    /// <summary>
    /// Район заказа
    /// </summary>
    public Region Region { get; set; }
    
    /// <summary>
    /// Время доставки заказа
    /// </summary>
    public DateTime Time { get; set; }
}