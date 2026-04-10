var builder = DistributedApplication.CreateBuilder(args);

var transactionService = builder.AddProject<Projects.TransactionClassificationApp_TransactionService>("transactionservice")
    .WithHttpHealthCheck("/health");

var classificationService = builder.AddProject<Projects.TransactionClassificationApp_ClassificationService>("classificationservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.TransactionClassificationApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(transactionService)
    .WithReference(classificationService)
    .WaitFor(transactionService)
    .WaitFor(classificationService);

builder.Build().Run();
