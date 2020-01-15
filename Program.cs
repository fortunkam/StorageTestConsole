using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;

namespace StorageTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connection String?");
            var connectionString = Console.ReadLine();

            try
            {
                var storageAccount = CloudStorageAccount.Parse(connectionString);
                var blobClient = storageAccount.CreateCloudBlobClient();
                var containers = blobClient.ListContainers();
                foreach (var item in containers)
                {
                    Console.WriteLine(item.Name);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();

        }
    }
}
