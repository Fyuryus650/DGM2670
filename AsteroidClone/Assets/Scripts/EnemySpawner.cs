using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyPrefab;
    private Vector3 spawnPos;
    public IntData lives;
    private int enemiesCount;
    public GameObject[] enemiesAlive;

    private void Awake()
    {
        spawnPos = new Vector3(Random.Range(-8.35f, 2.83f), 7.32f, 0.02f);
        Instantiate(enemyPrefab[0], spawnPos, enemyPrefab[0].transform.rotation);
    }
    public void Start()
    {
        enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
        StartCoroutine(SpawnEasyRoutine());
        enemiesCount = 1;
    }
    private void Update()
    {
        enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
    }

    public void SpawnEasyEnemies()
    {
        spawnPos = new Vector3(Random.Range(-8.35f, 2.83f), 7.32f, 0.02f);
        Instantiate(enemyPrefab[0], spawnPos, enemyPrefab[0].transform.rotation);
    }
    public void SpawnMediumEnemies()
    {
        spawnPos = new Vector3(Random.Range(-8.35f, 2.83f), 7.32f, 0.02f);
        Instantiate(enemyPrefab[1], spawnPos, enemyPrefab[1].transform.rotation);
    }
    public void SpawnHardEnemies()
    {
        spawnPos = new Vector3(Random.Range(-8.35f, 2.83f), 7.32f, 0.02f);
        Instantiate(enemyPrefab[2], spawnPos, enemyPrefab[2].transform.rotation);
    }
    public IEnumerator SpawnEasyRoutine()
    {

        while(lives.value > 0 && enemiesCount >= enemiesAlive.Length)
        {
            yield return new WaitForSeconds(5);

            SpawnEasyEnemies();
            enemiesCount++;
            
        }
    }
    public IEnumerator SpawnMedRoutine()
    {

        while (lives.value > 0 && enemiesCount >= enemiesAlive.Length)
        {
            yield return new WaitForSeconds(20);

            SpawnMediumEnemies();

        }
    }
    public IEnumerator SpawnHardRoutine()
    {

        while (lives.value > 0 && enemiesCount >= enemiesAlive.Length)
        {
            yield return new WaitForSeconds(20);

            SpawnHardEnemies();

        }
    }
}
