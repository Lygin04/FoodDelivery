using FoodDelivery.Dto;
using FoodDelivery.Entities;

namespace FoodDelivery.Interfaces;

public interface IOrderService
{
    /// <summary>
    /// Асинхронное добавление нового заказа в бд.
    /// </summary>
    /// <param name="orderDto"></param>
    Task AddAsync(OrderDto orderDto);
    /// <summary>
    /// Асинхронно возвращает все заказы из бд.
    /// </summary>
    /// <returns>Список заказов.</returns>
    Task<List<Order>> GetAllAsync();
    /// <summary>
    /// Асинхронно возвращает заказ по id из бд.
    /// </summary>
    /// <param name="id">Id заказа</param>
    /// <returns>Заказ</returns>
    Task<Order> GetByIdAsync(Guid id);
    /// <summary>
    /// Асинхронно возвращает все заказы по фильтру из бд.
    /// </summary>
    /// <param name="filterDto"></param>
    /// <returns></returns>
    Task<List<Order>> GetAllByFilterAsync(FilterDto filterDto);
}