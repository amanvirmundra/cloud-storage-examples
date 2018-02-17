namespace CloudStorage.Examples
{
    public interface IBlobOperations
    {
        void UploadBlockBlob(string name, string blobName, string filePath);
        void CopyBlockBlob(string from, string to);
    }
}
