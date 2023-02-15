using EFInvestigationDataFirst.Data;
using EFInvestigationDataFirst.Models;
using Microsoft.EntityFrameworkCore;


Console.WriteLine("Data First Entity Framework");


var context = new MembershipDb3Context();


foreach (var product in context.Products)
{

    Console.WriteLine(product);
}


/*
var carol = context.Members
                .Where(m => m.Name.Equals("Carol"))
                .Include("Orders.OrderDetails.Product")
                .FirstOrDefault();

Console.WriteLine(carol.Name);
Console.WriteLine(carol.Orders.Count);

foreach (var ord in carol.Orders)
{
    Console.WriteLine($"{ord.Id} - {ord.Comments}");

    foreach (var orderDetail in ord.OrderDetails)
    {

        Console.WriteLine($"{orderDetail.Product.Name} - {orderDetail.Quantity}");
    }
    Console.WriteLine("------------------------------------------");
}

*/

