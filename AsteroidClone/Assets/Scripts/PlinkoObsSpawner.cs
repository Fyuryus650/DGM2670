using System.Collections;
using UnityEngine;

public class PlinkoObsSpawner : MonoBehaviour
{
    private Vector3 spawnPos1, spawnPos2, spawnPos3, spawnPos4, spawnPos5;
    public bool isGameActive;
    public GameObject obsPreFab3, obsPreFab2;
    // Start is called before the first frame update
    private void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnObstacles());
    }
    void SpawnRow3()
    {
        spawnPos1 = new Vector3(6.4f, -1.86f, -0.16f);
        spawnPos2 = new Vector3(8.2f, -1.86f, -0.16f);
        spawnPos3 = new Vector3(4.57f, -1.86f, -0.16f);

        Instantiate(obsPreFab3, (spawnPos1), obsPreFab3.transform.rotation);
        Instantiate(obsPreFab3, (spawnPos2), obsPreFab3.transform.rotation);
        Instantiate(obsPreFab3, (spawnPos3), obsPreFab3.transform.rotation);
    }

    void SpawnRow2()
    {
        spawnPos4 = new Vector3(5.46f, -1.86f, -0.16f);
        spawnPos5 = new Vector3(7.33f, -1.86f, -0.16f);

        Instantiate(obsPreFab2, (spawnPos4), obsPreFab2.transform.rotation);
        Instantiate(obsPreFab2, (spawnPos5), obsPreFab2.transform.rotation);
    }
    public IEnumerator SpawnObstacles()
    {
        while (isGameActive == true)
        {
            yield return new WaitForSeconds(1.6f);
            
            SpawnRow3();

            yield return new WaitForSeconds(1.6f);
            
            SpawnRow2();            
        }
    }
}
