using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    StageData stageData;

    private void Update()
    {
        if (transform.position.y < stageData.LimitMin.y - 1 || transform.position.x < stageData.LimitMin.x -1 ||
            transform.position.x > stageData.LimitMax.x + 1)
        {
            Destroy(gameObject);
        }
    }
}
