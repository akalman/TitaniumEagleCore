using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging
{
    internal interface ISubscriber<T> where T : IMessage<T>
    {
        GameState Process(GameState state, T message);
    }
}
