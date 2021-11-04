using UnityEngine;

public class PlinkoSpawnBehaviour : MonoBehaviour
{
    public float spawnInt;
    public bool isGameActive = false;
    public GameObject plinkoObs;
    private Vector3 spawnPos;
    
    Ienumerator SpawnObstacles()
    {
        while (isGameActive == true)
        {
            yield return spawnInt;
        }
    }

    void PlinkoObsSpawn()
    {
        Instantiate(gameObject, gameObject.transform.rotation);
    }
}
