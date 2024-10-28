using FoodDelivery.Data;
using FoodDelivery.Entities;
using FoodDelivery.Enums;
using FoodDelivery.Interfaces;

namespace FoodDelivery.Repositories;

public class LoggerRepository(DataContext context) : ILoggerRepository
{
    public async Task AddAsync(Status status, string message)
    {
        var logger = new Logger
        {
            Status = status,
            Message = message
        };
        await context.Loggers.AddAsync(logger);
        await context.SaveChangesAsync();
    }
}