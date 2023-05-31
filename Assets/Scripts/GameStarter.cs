using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private CoinsCollectorVisualiser _coinsCollectorVisualiser;
    [SerializeField] private ObjectsFactory _factory;
    [SerializeField] private ObjectsPool _coinsPool;
    [SerializeField] private ObjectsPool _obstaclesPool;
    [SerializeField] private Coin _coinTemplate;
    [SerializeField] private Obstacle _obstacleTemplate;
    [SerializeField] private ObjectsSpawner _spawner;
    [SerializeField] private int _poolsSize;

    private void Awake()
    {
        CoinsCollector newCollector = new CoinsCollector();
        _player.Init(newCollector);
        _coinsCollectorVisualiser.Init(newCollector);
        _obstaclesPool.Init(_factory.CreateLevelObjects(_obstacleTemplate, _poolsSize, _obstaclesPool.transform));
        _coinsPool.Init(_factory.CreateLevelObjects(_coinTemplate, _poolsSize, _coinsPool.transform));
        _spawner.Init();
    }
}
