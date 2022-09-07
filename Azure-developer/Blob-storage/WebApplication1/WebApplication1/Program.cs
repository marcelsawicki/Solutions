using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
BlobStorageService.CreateAnonymousBlobClient();
BlobStorageService.ListBlobsAnonymously();

app.MapGet("/", () => "Hello World!");

app.Run();