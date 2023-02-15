// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SqlServerDataFirstInvestigation.Data;
using SqlServerDataFirstInvestigation.Models;

Console.WriteLine("SQL Server Data First");

var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddUserSecrets<Program>();

var configuration = builder.Build();
var connectionString = configuration.GetConnectionString("azuresql");

var optionsBuilder = new DbContextOptionsBuilder<trainingdbContext>();
optionsBuilder.UseSqlServer(connectionString);

var context = new trainingdbContext(optionsBuilder.Options);


foreach(Member m in context.Members)
{
    Console.WriteLine(m);
}

