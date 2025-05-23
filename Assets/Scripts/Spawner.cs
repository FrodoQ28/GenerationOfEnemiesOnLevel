using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private float _delay = 2f;
    private int _currentSpawnPoint = 0;

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);
        bool isRunning = true;

        while (isRunning)
        {
            ShuffleList();

            _spawnPoints[_currentSpawnPoint].CreateEnemy();

            yield return wait;
        }
    }

    private void ShuffleList()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            int randomIndex = Random.Range(0, _spawnPoints.Count);
            SpawnPoint temp = _spawnPoints[i];
            _spawnPoints[i] = _spawnPoints[randomIndex];
            _spawnPoints[randomIndex] = temp;
        }
    }
}
