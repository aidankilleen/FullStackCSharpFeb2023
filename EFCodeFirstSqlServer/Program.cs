// See https://aka.ms/new-console-template for more information
using EFCodeFirstSqlServer.Data;
using EFCodeFirstSqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

Console.WriteLine("EF Code First - SQL Server (localdb)");


var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddUserSecrets<Program>()
                    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");

Console.WriteLine($"Connection: {connectionString}");


var optionsBuilder = new DbContextOptionsBuilder<MemberDbContext>();
optionsBuilder.UseSqlServer(connectionString);

var context = new MemberDbContext(optionsBuilder.Options);

foreach (Member m in context.Members)
{
    Console.WriteLine(m);
}