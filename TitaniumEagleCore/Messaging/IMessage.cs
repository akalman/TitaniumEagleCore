namespace TitaniumEagleCore.Messaging
{
    public interface IMessage<T> where T : IMessage<T> { }
}
