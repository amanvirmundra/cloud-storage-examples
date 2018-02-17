using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;

namespace CloudStorage.Examples
{
    public class BlobContainerOperations : IContainerOperations, IBlobOperations
    {
        private CloudStorageAccount storageAccount;
        private CloudBlobClient client;

        public BlobContainerOperations()
        {
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnection"));
            client = storageAccount.CreateCloudBlobClient();
        }

        public void Create(string name)
        {
            var blob = getBlobContainer(name);
            blob.CreateIfNotExists(BlobContainerPublicAccessType.Blob);
        }

        public void Delete(string name)
        {
            var blob = getBlobContainer(name);

            blob.DeleteIfExists();
        }

        private CloudBlobContainer getBlobContainer(string name)
        {
            var blob = client.GetContainerReference(name);
            return blob;
        }

        public void CopyBlockBlob(string from, string to)
        {
            throw new NotImplementedException();
        }

        public void UploadBlockBlob(string name, string blobName, string filePath)
        {
            var blob = getBlobContainer(name);
            var blockBlob = blob.GetBlockBlobReference(blobName);

            using (var stream = File.OpenRead(filePath))
            {
                blockBlob.UploadFromStream(stream);
            }
        }


    }
}
