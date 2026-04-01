using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TransactionService_Api>("transactions");
builder.AddProject<Projects.ClassificationService>("classification");

builder.Build().Run();

