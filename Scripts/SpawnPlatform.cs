using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private Vector3 _enemyMoveDirection;

    public Vector3 GetSpawnPoint()
    {
        float y = 1.5f;
        
        return new Vector3(transform.position.x, y, transform.position.z);
    }

    public Vector3 GetDirection()
    {        
        return _enemyMoveDirection;
    }
}
