using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
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
            QueueProperties properties = queueClient.GetProperties();

            // Retrieve the cached approximate message count.
            int cachedMessagesCount = properties.ApproximateMessagesCount;

            // Display number of messages.
            Console.WriteLine($"Number of messages in queue: {cachedMessagesCount}");

            Console.WriteLine("Podaj tresc nowej message?");
            string bodyMessage = Console.ReadLine();
            // Send a message to the queue
            string message = string.Format(bodyMessage);
            var result = queueClient.SendMessage(message);

            // Get the message from the queue
            QueueMessage[] retrievedMessage = queueClient.ReceiveMessages();

            Console.WriteLine("Czy nadpisac message? (tak/nie)");
            string updateMessage = Console.ReadLine();
            if (updateMessage == "tak")
            {
                // Update the message contents
                queueClient.UpdateMessage(retrievedMessage[0].MessageId,
                        retrievedMessage[0].PopReceipt,
                        "Updated contents",
                        TimeSpan.FromSeconds(60.0)  // Make it invisible for another 60 seconds
                    );
            }

                // Process (i.e. print) the message in less than 30 seconds
                Console.WriteLine($"Dequeued message: '{retrievedMessage[0].Body}'");

            Console.WriteLine("Czy skasować pierwsza message z kolejki? (tak/nie)");
            string deleteMessage = Console.ReadLine();
            if (deleteMessage == "tak")
            {
                // Delete the message
                queueClient.DeleteMessage(retrievedMessage[0].MessageId, retrievedMessage[0].PopReceipt);
            }
            
        }
    }
}