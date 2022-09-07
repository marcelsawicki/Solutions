using Azure.Core;
using Azure.Identity;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;

namespace WebApplication1
{
    public class BlobStorageService
    {
        public static void GetBlobServiceClient(ref BlobServiceClient blobServiceClient,string accountName, string accountKey)
        {
            Azure.Storage.StorageSharedKeyCredential sharedKeyCredential =
                new StorageSharedKeyCredential(accountName, accountKey);

            string blobUri = "https://" + accountName + ".blob.core.windows.net";

            blobServiceClient = new BlobServiceClient
                (new Uri(blobUri), sharedKeyCredential);
        }

        public static void GetBlobServiceClientSAS(ref BlobServiceClient blobServiceClient, string accountName, string sasToken)
        {
            string blobUri = "https://" + accountName + ".blob.core.windows.net";

            blobServiceClient = new BlobServiceClient
            (new Uri($"{blobUri}?{sasToken}"), null);
        }

        public static void GetBlobServiceClientAzureAD(ref BlobServiceClient blobServiceClient, string accountName, string clientID, string clientSecret, string tenantID)
        {

            TokenCredential credential = new ClientSecretCredential(
                tenantID, clientID, clientSecret, new TokenCredentialOptions());

            string blobUri = "https://" + accountName + ".blob.core.windows.net";

            blobServiceClient = new BlobServiceClient(new Uri(blobUri), credential);
        }

        public static void CreateAnonymousBlobClient()
        {
            // Create the client object using the Blob storage endpoint for your account.
            BlobServiceClient blobServiceClient = new BlobServiceClient
                (new Uri(@"https://storagesamples.blob.core.windows.net/"));

            // Get a reference to a container that's available for anonymous access.
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient("sample-container");

            // Read the container's properties. 
            // Note this is only possible when the container supports full public read access.          
            Console.WriteLine(container.GetProperties().Value.LastModified);
            Console.WriteLine(container.GetProperties().Value.ETag);
        }

        public static void ListBlobsAnonymously()
        {
            // Get a reference to a container that's available for anonymous access.
            BlobContainerClient container = new BlobContainerClient
                (new Uri(@"https://storagesamples.blob.core.windows.net/sample-container"));

            // List blobs in the container.
            // Note this is only possible when the container supports full public read access.
            foreach (BlobItem blobItem in container.GetBlobs())
            {
                Console.WriteLine(container.GetBlockBlobClient(blobItem.Name).Uri);
            }
        }


    }
}
