using Cysharp.Threading.Tasks;
using Network.Services;
using Services;
using UI.Factory;

namespace Infrastructure
{
    public class Game
    {
        private readonly NetworkClient _client;
        private readonly StaticDataService _staticData;
        private readonly UIFactory _uiFactory;

        public Game(NetworkClient client, StaticDataService staticData, UIFactory uiFactory)
        {
            _client = client;
            _staticData = staticData;
            _uiFactory = uiFactory;
        }

        public async void Start()
        {
            _staticData.Load();
            await this.Connect("1111");
            //_uiFactory.CreateUIRoot();
        }

        public async UniTask<ConnectionResult> Connect(string username) =>
            await _client.Connect(username);

        public async UniTask Disconnect() =>
            await _client.Disconnect();
    }
}