using FoodDelivery.Dto;
using FoodDelivery.Entities;
using FoodDelivery.Interfaces;

namespace FoodDelivery.Services;

public class OrderService(IOrderRepository repository) : IOrderService
{
    public Task AddAsync(OrderDto orderDto)
    {
        repository.AddAsync(orderDto);
        return Task.CompletedTask;
    }

    public Task<List<Order>> GetAllAsync()
    {
        return repository.GetAllAsync();
    }

    public Task<Order> GetByIdAsync(Guid id)
    {
        return repository.GetByIdAsync(id);
    }

    public async Task<List<Order>> GetAllByFilterAsync(FilterDto filterDto)
    {
        return await repository.GetAllByFilterAsync(filterDto);
    }
}