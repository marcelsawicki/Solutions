using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;

public class Program 
{

    public static void Main(string[] args)
    {
        // Build a config object, using env vars and JSON providers.
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        
        var connectionString = config.GetSection("ConnectionStringBlobStorage").Value.ToString();
        var queueName = config["QueueNameBlobStorage"];

        QueueClient queueClient = new QueueClient(connectionString, queueName);

        // Create the queue if it doesn't already exist
        queueClient.CreateIfNotExists();

        if (queueClient.Exists())
        {
            // Send a message to the queue
            string message = string.Format("Hello world!");
            var result = queueClient.SendMessage(message);
        }
    }
}