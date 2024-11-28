using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Vector3 _startPoint;
    [SerializeField] Vector3 _endPoint;

    private int _speed = 4;
    public Vector3 Position => transform.position;   

    private void Awake()
    {
        transform.position = _startPoint;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint, _speed * Time.deltaTime);

        if (transform.position == _endPoint)
        {
            Vector3 temp = _startPoint;
            _startPoint = _endPoint;
            _endPoint = temp;
        }
    }
}
