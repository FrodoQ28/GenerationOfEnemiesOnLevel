using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint _spawnPoint1;
    [SerializeField] private SpawnPoint _spawnPoint2;
    [SerializeField] private SpawnPoint _spawnPoint3;
    [SerializeField] private SpawnPoint _spawnPoint4;
    [SerializeField] private Enemy _enemyPrefab;

    private List<SpawnPoint> _spawnPoints;
    private float _delay = 2f;

    private void Awake()
    {
        _spawnPoints = new List<SpawnPoint>()
        { _spawnPoint1, _spawnPoint2, _spawnPoint3, _spawnPoint4 };
    }

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

            Enemy newEnemy = Instantiate(_enemyPrefab, _spawnPoints[0].transform);
            newEnemy.MovementDirection = Vector3.zero - _spawnPoints[0].transform.position;

            yield return wait;
        }
    }

    private void ShuffleList()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            int j = Random.Range(0, _spawnPoints.Count);
            SpawnPoint temp = _spawnPoints[i];
            _spawnPoints[i] = _spawnPoints[j];
            _spawnPoints[j] = temp;
        }
    }
}
