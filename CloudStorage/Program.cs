using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnection"));

            var client = storageAccount.CreateCloudBlobClient();
            var blob = client.GetContainerReference("images");

            blob.CreateIfNotExists(BlobContainerPublicAccessType.Blob);


            var blockBlob = blob.GetBlockBlobReference("photo.jpg");

            using (var stream = File.OpenRead(@"F:\Photoan\DSCN0002.JPG"))
            {
                blockBlob.UploadFromStream(stream);
            }

            Console.ReadKey();
        }
    }
}
