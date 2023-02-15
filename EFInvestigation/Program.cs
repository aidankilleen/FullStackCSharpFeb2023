// See https://aka.ms/new-console-template for more information


using EFInvestigation.Data;
using EFInvestigation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .AddUserSecrets<Program>();

var configuration = builder.Build();
var title = configuration.GetValue<string>("title");

Console.WriteLine(title);

var username = configuration.GetValue<string>("username");
var password = configuration.GetValue<string>("password");

Console.WriteLine (username);
Console.WriteLine(password);


using MembershipDatabaseContext context = new MembershipDatabaseContext();

/*
var member = new Member() { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = false };

context.Members.Add(member);
*/

/*
var member = context.Members.First<Member>();

var order = new Order() { Member = member, OrderPlaced = DateTime.Now, Comments = "First test order for member 1" };

context.Add(order);
*/

/*
context.Products.Add(new Product() { Name = "Dell Laptop", Price = 799.99M, Description = "A High spec laptop" });
context.Products.Add(new Product() { Name = "Keyboard", Price = 29.99M, Description = "A high spec gaming keyboard" });
context.Products.Add(new Product() { Name = "Mouse", Price = 19.99M, Description = "A wireless mouse" });
context.Products.Add(new Product() { Name = "Monitor", Price = 149.99M, Description = "A 28inch monitor" });

context.SaveChanges();
*/


/*
var member = new Member() { Name = "Carol", Email = "carol@gmail.com", Active = false };

Console.WriteLine(member);

context.Add(member);
context.SaveChanges();

Console.WriteLine(member);


var order = new Order() { Member = member, OrderPlaced = DateTime.Now, Comments = "Another order" };

member.Orders = new List<Order>{ 
    order 
};


var product = context.Products.First<Product>();


order.OrderDetails = new List<OrderDetail>
{
    new OrderDetail() { Quantity = 1, Order = order, ProductId = 1 },
    new OrderDetail() { Quantity = 2, Order = order, ProductId = 2 },
    new OrderDetail() { Quantity = 3, Order = order, ProductId = 3 }
};


context.Add(order);
context.SaveChanges();
*/



var carol = context.Members
                .Where(m => m.Name.Equals("Carol"))
                .Include("Orders.OrderDetails.Product")
                .FirstOrDefault();

Console.WriteLine(carol.Name);

Console.WriteLine(carol.Orders.Count);

foreach (var ord in carol.Orders)
{
    Console.WriteLine($"{ord.Id} - { ord.Comments }");
   
    foreach (var orderDetail in ord.OrderDetails)
    {

        Console.WriteLine($"{orderDetail.Product.Name} - {orderDetail.Quantity}");
    }
    Console.WriteLine("------------------------------------------");
}





//context.SaveChanges();






