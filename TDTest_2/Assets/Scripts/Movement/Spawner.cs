using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform enemyPreFab;
    public Transform spawnPoint;
    //public Transform endPoint;

    public float WaitTimer = 1f;
    public float nextWaveCounter = 5f;
    private float countdown = 2f;

    private int waveNumberIndex = 0;

    void Update()
    {
        //DestroyEnemy();

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = nextWaveCounter;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveNumberIndex++;

        for (int i = 0; i < waveNumberIndex; i++)
        {
            SpawnUnit();
            yield return new WaitForSeconds(WaitTimer);
        }
    }

    void SpawnUnit()
    {
        Instantiate(enemyPreFab, spawnPoint.position, spawnPoint.rotation);
    }

   /* void DestroyEnemy()
    {
        if (enemyPreFab.position == endPoint.position)
        {
            Destroy(enemyPreFab);
        }
    }*/
}
