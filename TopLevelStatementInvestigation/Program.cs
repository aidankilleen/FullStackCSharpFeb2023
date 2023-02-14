// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using TopLevelStatementInvestigation;


Console.WriteLine("Top Level Statement");


string name = "Aidan";

Console.WriteLine(name);

//string password = System.Configuration.ConfigurationManager.AppSettings["password"];

//Console.WriteLine(password);


string path = Environment.GetEnvironmentVariable("HOMEPATH");

string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

Console.WriteLine(path);

var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                                .AddUserSecrets<Program>();

var configuration = builder.Build();

string greeting = configuration.GetValue<string>("greeting");

Console.WriteLine(greeting);


string secretgreeting = configuration.GetValue<string>("secretgreeting");

Console.WriteLine(secretgreeting);


string productionmessage = configuration.GetValue<string>("productionmessage");

Console.WriteLine(productionmessage);


string apptitle = configuration.GetValue<string>("apptitle");

Console.WriteLine(apptitle);


Member m = new Member() { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = false };

Console.WriteLine(m);



List<Member> members = new List<Member>();

members.Add(m);







