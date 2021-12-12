using System.Collections;
using UnityEngine;

public class PlinkoObsSpawner : MonoBehaviour
{
    private Vector3 spawnPos1, spawnPos2, spawnPos3, spawnPos4, spawnPos5, ballSpawnRandom;
    private float ballXspawnPos1 = 4.59f, ballXSpawnPos2 = 8.19f;
    public bool isGameActive;
    public GameObject obsPreFab3, obsPreFab2, plinkoBallPrefab;
    public IntData plinkoAmntData;
    public int instances;

    // Start is called before the first frame update
    private void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnObstacles());
        StartCoroutine(SpawnBallRoutine());
        SpawnBall();
    }
    void SpawnRow3()
    {
        spawnPos1 = new Vector3(6.4f, -1.86f, -0.16f);
        spawnPos2 = new Vector3(8.45f, -1.86f, -0.16f);
        spawnPos3 = new Vector3(4.34f, -1.86f, -0.16f);

        Instantiate(obsPreFab3, (spawnPos1), obsPreFab3.transform.rotation);
        Instantiate(obsPreFab3, (spawnPos2), obsPreFab3.transform.rotation);
        Instantiate(obsPreFab3, (spawnPos3), obsPreFab3.transform.rotation);
    }

    void SpawnRow2()
    {
        spawnPos4 = new Vector3(5.37f, -1.86f, -0.16f);
        spawnPos5 = new Vector3(7.42f, -1.86f, -0.16f);

        Instantiate(obsPreFab2, (spawnPos4), obsPreFab2.transform.rotation);
        Instantiate(obsPreFab2, (spawnPos5), obsPreFab2.transform.rotation);
    }

    public void SpawnBall()
    {
        ballSpawnRandom = new Vector3(Random.Range(ballXspawnPos1, ballXSpawnPos2), 8.18f, -0.25f);

        Instantiate(plinkoBallPrefab, (ballSpawnRandom), plinkoBallPrefab.transform.rotation);
    }

    public void ResetInstances()
    {
        instances = plinkoAmntData.value;
        StartCoroutine(SpawnBallRoutine());
    }

    public IEnumerator SpawnObstacles()
    {
        while (isGameActive == true)
        {
            yield return new WaitForSeconds(1.7f);
            
            SpawnRow3();

            yield return new WaitForSeconds(1.7f);
            
            SpawnRow2();
        }
    }
    public IEnumerator SpawnBallRoutine()
    {
        if (isGameActive == true && instances > 0)
        {
            yield return new WaitForSeconds(1.0f);

            SpawnBall();
            instances--;
        }
    }
}
