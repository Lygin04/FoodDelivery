using System.ComponentModel.DataAnnotations;
using FoodDelivery.Enums;

namespace FoodDelivery.Entities;

/// <summary>
/// Модель логирования.
/// </summary>
public class Logger
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Статус состояния.
    /// </summary>
    public Status Status { get; set; }
    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Message { get; set; } = string.Empty;
    /// <summary>
    /// Время.
    /// </summary>
    public DateTime Date { get; set; } = DateTime.Now;
}