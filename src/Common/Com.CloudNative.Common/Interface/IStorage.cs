namespace Com.CloudNative.Common.Interface
{
    public interface IStorage
    {
        object Read(string path);
        object Write(string path, object value);

    }
}