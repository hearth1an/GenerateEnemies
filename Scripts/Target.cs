using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{    
    [SerializeField] private List<RoutePoint> _routePoints;

    private int _speed = 4;
    private int _currentPointIndex = 0;
    private int _firstRouteIndex = 0;
    public Vector3 Position => transform.position;   

    private void Awake()
    {
        transform.position = _routePoints[_currentPointIndex].Position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float minDistance = 0.1f;

        if (Vector3.Distance(transform.position, _routePoints[_currentPointIndex].Position) < minDistance)
        {
            _currentPointIndex++;

            if (_currentPointIndex >= _routePoints.Count)
            {
                _currentPointIndex = _firstRouteIndex;
                return;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, _routePoints[_currentPointIndex].Position, _speed * Time.deltaTime);
    }
}
