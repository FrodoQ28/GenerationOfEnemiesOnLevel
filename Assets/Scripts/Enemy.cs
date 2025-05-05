using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private float _speed = 5f;

    private void Update()
    {
        if (_target != null)
            transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Target target) =>
        _target = target;
}
