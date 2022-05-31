using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
    [SerializeField]
    StageData stageData;
    [SerializeField]
    int spawnDelay = 1;
    float x;

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            x = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);

            GameObject enemy = Instantiate(enemyPrefab, new Vector3(x, stageData.LimitMax.y + 3), Quaternion.identity);

            yield return new WaitForSeconds(spawnDelay);
        }
    }

    private void Awake()
    {
        StartCoroutine(EnemySpawn());
    }
}
