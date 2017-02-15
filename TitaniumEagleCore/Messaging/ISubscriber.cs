using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging
{
    internal interface ISubscriber<T> where T : IMessage
    {
        GameState Process(GameState state, T message);
    }
}
