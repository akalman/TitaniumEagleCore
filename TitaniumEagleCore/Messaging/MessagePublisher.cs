using System;
using System.Collections.Generic;
using System.Reflection;
using TitaniumEagleCore.Context;
using TitaniumEagleCore.Messaging.Subscribers;
using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging
{
    public class MessagePublisher
    {
        private IDictionary<Type, object> _subscribers = new Dictionary<Type, object>();

        public MessagePublisher()
        {
            var subscribers = new object[]
            {
                new PlayerSelectedCharacterMessageSubscriber(),
                new PlayerSelectedEquipmentMessageSubscriber()
            };

            Action<object> addToDictionary = obj =>
            {
                var type = obj.GetType()
                .GetInterface("ISubscriber~1")
                .GetGenericArguments()[0];
                _subscribers.Add(type, obj);
            };
            Array.ForEach(subscribers, addToDictionary);
        }

        public void Publish(IMessage message)
        {
            var subscriber = _subscribers[message.GetType()];
            var resultState = subscriber.GetType().InvokeMember("Process", BindingFlags.Default, null, subscriber, new object[] { GameContext.State, message }) as GameState;
            GameContext.State = resultState;
        }
    }
}
