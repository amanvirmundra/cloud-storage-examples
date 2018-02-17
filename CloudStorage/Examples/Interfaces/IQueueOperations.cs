using Microsoft.WindowsAzure.Storage.Queue;

namespace CloudStorage.Examples
{
    public interface IQueueOperations
    {
        void AddMessage(CloudQueueMessage message);
        CloudQueueMessage GetMessage();
        CloudQueueMessage PeekMessage();
        void DeleteMessage(CloudQueueMessage message);
    }
}
