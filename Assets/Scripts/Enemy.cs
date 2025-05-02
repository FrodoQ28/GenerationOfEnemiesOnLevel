using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _movementDirection;

    private void Awake()
    {
        _movementDirection = Vector3.zero;
    }

    private void Update()
    {
        transform.Translate(_movementDirection * Time.deltaTime);
    }

    public void SetMovementDirection(Vector3 movementDirection) =>
        _movementDirection = movementDirection;
}
