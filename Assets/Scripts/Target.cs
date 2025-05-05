using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints;

    private int _currentWaypoint = 0;
    private float _speed = 5.5f;

    private void Awake()
    {
        transform.position = _waypoints[_currentWaypoint].transform.position;
    }

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].transform.position)
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Count;

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].transform.position, _speed * Time.deltaTime);
    }
}
