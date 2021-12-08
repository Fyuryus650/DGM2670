using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemies;
    private Vector3 spawnPos;
    public IntData lives;
    private int enemiesCount;
    public GameObject[] enemiesAlive;

    private void Awake()
    {
        spawnPos = new Vector3(Random.Range(-8.35f, 2.83f), 7.32f, 0.02f);
        Instantiate(enemies, spawnPos, enemies.transform.rotation);
    }
    void Start()
    {
        enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
        StartCoroutine(SpawnRoutine());
        enemiesCount = 1;
    }
    private void Update()
    {
        enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
    }

    public void SpawnEnemies()
    {
        Instantiate(enemies, spawnPos, enemies.transform.rotation);
    }

    public IEnumerator SpawnRoutine()
    {

        while(lives.value > 0 && enemiesCount > enemiesAlive.Length)
        {
            yield return new WaitForSeconds(15);

            SpawnEnemies();
        }
    }
}
