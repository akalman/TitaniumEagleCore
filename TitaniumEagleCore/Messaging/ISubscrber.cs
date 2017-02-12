namespace TitaniumEagleCore.Messaging
{
    internal interface ISubscrber<T> where T : IMessage
    {
        void Process(T message);
    }
}
