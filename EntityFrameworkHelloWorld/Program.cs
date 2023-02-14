using EntityFrameworkHelloWorld.data;
using EntityFrameworkHelloWorld.models;

Console.WriteLine("Entity Framework Hello World");


using MembershipDatabaseContext context = new MembershipDatabaseContext();

/*
Member m = new Member() { Name = "Carol", Email = "carol@gmail.com", Active = false };

Console.WriteLine(m);

context.Add(m);

context.SaveChanges();

Console.WriteLine(m);
*/

/*
context.Products.Add(new Product() { Name = "Dell Laptop", Price = 999.99M });
context.Products.Add(new Product() { Name = "Keyboard", Price = 39.99M });
context.Products.Add(new Product() { Name = "Mouse", Price = 14.99M });
context.Products.Add(new Product() { Name = "Monitor", Price = 147.99M });
*/




var member = context.Members.First<Member>();

var order = new Order() { OrderPlaced = DateTime.Now, Member = member };


context.Add(order);

order.OrderDetails = new List<OrderDetail>
{
    new OrderDetail() { Quantity = 1, Order = order, ProductId = 1 }
};


/*
if (member.AccessLogs == null)
{
    member.AccessLogs = new List<AccessLog>();
}
member.AccessLogs.Add(new AccessLog() { Member = member, Date = DateOnly.FromDateTime(DateTime.Now) });
*/

context.SaveChanges();

/*


foreach (Member m in context.Members)
{

    Console.WriteLine(m);

    AccessLog log = ;
    context.SaveChanges();


}

*/










