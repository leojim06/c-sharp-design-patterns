namespace FirebaseDumy
{
    public interface IFirebaseSender
    {
        void Connect(string username, string password);
        bool Send(Device device, Message message);
    }
}
