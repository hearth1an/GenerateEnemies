using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPlatform> _spawnPlatforms;
    [SerializeField] private Enemy _enemyPrefab;

    private int _spawnRate = 2;

    private void Start()
    {
        int time = 0;

        InvokeRepeating(nameof(Spawn), time, _spawnRate);       
    }

    private SpawnPlatform PickPlatform()
    {
        int minPlatformCount = 0;

        return _spawnPlatforms[Random.Range(minPlatformCount, _spawnPlatforms.Count)];
    }

    private void Spawn()
    {
        SpawnPlatform spawnPlatform = PickPlatform();
        Enemy enemy = Instantiate(_enemyPrefab, spawnPlatform.GetSpawnPoint(), _enemyPrefab.Rotation);        

        enemy.SetDirection(spawnPlatform.GetDirection());
    }
}
