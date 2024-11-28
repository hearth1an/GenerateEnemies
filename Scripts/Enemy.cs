using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private int _speed = 3;

    public Quaternion Rotation => transform.rotation;

    private void Update()
    {
        Move();
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.Position, _speed * Time.deltaTime);        
    }
}
