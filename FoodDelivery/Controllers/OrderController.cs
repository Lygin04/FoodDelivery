using FoodDelivery.Dto;
using FoodDelivery.Enums;
using FoodDelivery.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(IOrderService orderService, ILoggerRepository logger) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Add(OrderDto orderDto)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
        
            await orderService.AddAsync(orderDto);
            await logger.AddAsync(Status.Debug, "Добавлен новый заказ");
            return Ok();
        }
        catch (Exception e)
        {
            await logger.AddAsync(Status.Error, e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var orders = await orderService.GetAllAsync();
            await logger.AddAsync(Status.Debug, "Получены все заказы");
            return Ok(orders);
        }
        catch (Exception e)
        {
            await logger.AddAsync(Status.Error, e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var order = await orderService.GetByIdAsync(id);
            await logger.AddAsync(Status.Debug, "Получены заказ по Id");
            return Ok(order);
        }
        catch (Exception e)
        {
            await logger.AddAsync(Status.Error, e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpPost("/filter")]
    public async Task<IActionResult> GetAllByFilter(FilterDto filterDto)
    {
        try
        {
            var orders = await orderService.GetAllByFilterAsync(filterDto);
            await logger.AddAsync(Status.Debug, "Получены все заказы по фильтру");
            return Ok(orders);
        }
        catch (Exception e)
        {
            await logger.AddAsync(Status.Error, e.Message);
            return BadRequest(e.Message);
        }
    }
}