using Network.Services;
using Network.Services.RoomHandlers;
using Reflex.Core;
using Services;
using UI.Factory;
using UnityEngine;

namespace Infrastructure
{
    public class GameInstaller : MonoBehaviour, IInstaller
    {
        public void InstallBindings(ContainerBuilder builder)
        {
            builder.AddSingleton(typeof(Injector));
            builder.AddSingleton(typeof(Game));
            builder.AddSingleton(typeof(Assets));
            builder.AddSingleton(typeof(StaticDataService));
            builder.AddSingleton(typeof(UIFactory));
            builder.AddSingleton(typeof(NetworkClient));
            builder.AddSingleton(typeof(NetworkStateInitializer), typeof(INetworkRoomHandler));
        }
    }
}