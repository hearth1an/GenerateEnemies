using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private Target _target;

    public Target Target => _target;

    public Vector3 GetSpawnPoint()
    {
        float additionalPosition = 1.5f;
        
        return new Vector3(transform.position.x, transform.position.y + additionalPosition, transform.position.z);
    }
}
