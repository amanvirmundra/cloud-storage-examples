namespace CloudStorage.Examples
{
    public interface IBlobOperations
    {
        int Create(string name);
        void Delete(string name);

        void UploadBlockBlob();
        void CopyBlockBlob(string from, string to);
    }
}
