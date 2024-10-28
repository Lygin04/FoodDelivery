using FoodDelivery.Data;
using FoodDelivery.Dto;
using FoodDelivery.Entities;
using FoodDelivery.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repositories;

public class OrderRepository(DataContext context) : IOrderRepository
{
    public async Task AddAsync(OrderDto orderDto)
    {
        var order = new Order
        {
            Weight = orderDto.Weight,
            Region = orderDto.CityDistrict,
            Time = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss."))
        };
        await context.Orders.AddAsync(order);
        await context.SaveChangesAsync();
    }

    public async Task<List<Order>> GetAllAsync()
    {
        return await context.Orders.ToListAsync();
    }

    public async Task<Order> GetByIdAsync(Guid id)
    {
        var order = await context.Orders.FirstOrDefaultAsync(o => o.Id == id) 
                    ?? throw new InvalidOperationException();
        return order;
    }
    
    public async Task<List<Order>> GetAllByFilterAsync(FilterDto filterDto)
    {
        var parsedDate = filterDto.GetFirstDeliveryDateTimeParsed();
        return await context.Orders
            .Where(o => o.Region == filterDto.CityDistrict && o.Time >= parsedDate)
            .ToListAsync();
    }
}