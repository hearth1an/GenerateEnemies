using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPlatform> _spawnPlatforms;
    [SerializeField] private Enemy _enemyPrefab;

    private int _spawnRate = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private SpawnPlatform PickRandomPlatform()
    {
        int minPlatformCount = 0;

        return _spawnPlatforms[Random.Range(minPlatformCount, _spawnPlatforms.Count)];
    }

    private void Spawn()
    {
        SpawnPlatform spawnPlatform = PickRandomPlatform();
        Enemy enemy = Instantiate(_enemyPrefab, spawnPlatform.GetSpawnPoint(), _enemyPrefab.Rotation);

        enemy.SetTarget(spawnPlatform.Target);
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(_spawnRate);
        }
    }
}
