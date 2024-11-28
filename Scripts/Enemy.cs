using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _moveDirection;

    public Quaternion Rotation => transform.rotation;

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _moveDirection = direction;
    }

    private void Move()
    {        
        transform.position += _moveDirection;
    }
}
