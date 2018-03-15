namespace DidILockMy.Contracts
{
    public interface ILocalFilePathProvider
    {
        string GetPathForFile(string fileName);
    }
}