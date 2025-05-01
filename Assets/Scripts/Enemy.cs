using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _movementDirection;

    public Vector3 MovementDirection { set {  _movementDirection = value; } }

    private void Awake()
    {
        _movementDirection = Vector3.zero;
    }

    private void Update()
    {
        transform.Translate(_movementDirection * Time.deltaTime);
    }
}
