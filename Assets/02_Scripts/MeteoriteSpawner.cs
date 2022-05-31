using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject linePrefab;
    [SerializeField]
    GameObject meteorPrefab;
    float spawnTime;
    float curTime;

    IEnumerator SpawnLine()
    {
        while (true)
        {
            GameObject line = Instantiate(linePrefab, new Vector3(GameObject.Find("Player").transform.position.x, 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(1f);

            GameObject meteor = Instantiate(meteorPrefab);
            meteor.transform.position = new Vector3(line.transform.position.x, 6, 0);

            Destroy(line);

            yield return new WaitForSeconds(Random.Range(1, 4));
        }
    }

    private void Awake()
    {
        StartCoroutine(SpawnLine());
    }
}
