using Ainimals.io.Data;
using Ainimals.io.Migrations;
using Ainimals.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ainimals.io;

public class OrderDto
{
    public string UserId { get; set; }
    public string PaymentStateId { get; set; }
    
}

public static class TestApi
{
    public static void AddOrderApi(this WebApplication app)
    {
        app.MapPost("/test/order/",
            ([FromBody] OrderDto orderDto, [FromServices] IOrderRepository repository) =>
            {
                repository.CreateFromDto(orderDto);
            }
        );
        app.MapGet("/test/order/", ([FromServices] IOrderRepository repository) =>
        repository.GetOrder("2d54e91b-0fd6-458d-a95a-bac803355e82"));



        app.MapPut("/test/order/{id}", async ([FromRoute] string id, [FromBody] OrderDto order, [FromServices] IOrderRepository repository) =>
        {
            await repository.Add(id, order);
            
        });
        app.MapPatch("/test/order/{id}", async ([FromRoute] string id, [FromBody] OrderDto order, [FromServices] IOrderRepository repository) =>
        {
            await repository.Update(id, order);
            
        });

     
    }

    
}