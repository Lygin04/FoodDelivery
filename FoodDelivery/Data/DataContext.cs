using FoodDelivery.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<Logger> Loggers => Set<Logger>();
}