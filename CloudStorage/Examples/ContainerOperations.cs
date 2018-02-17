using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using System;

namespace CloudStorage.Examples
{
    public class ContainerOperations : IContainerOperations
    {
        private CloudStorageAccount storageAccount;

        public ContainerOperations()
        {
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnection"));
        }

        public void Create(string name)
        {
            var client = storageAccount.CreateCloudBlobClient();
            var blob = client.GetContainerReference(name);

            blob.CreateIfNotExists();
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }
    }
}
