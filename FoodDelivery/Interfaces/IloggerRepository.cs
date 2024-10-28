using FoodDelivery.Entities;
using FoodDelivery.Enums;

namespace FoodDelivery.Interfaces;

public interface ILoggerRepository
{
    /// <summary>
    /// Асинхронное добавление нового лога в бд
    /// </summary>
    /// <param name="status">Статус лога</param>
    /// <param name="message">Комментарий к логу</param>
    Task AddAsync(Status status, string message);
}