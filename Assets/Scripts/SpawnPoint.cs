using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;

    public void CreateEnemy()
    {
        Enemy newEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        newEnemy.SetTarget(_target);
    }
}