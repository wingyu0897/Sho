using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float scrollSize = 11.5f;
    private void Update()
    {
        if (transform.position.y <= -scrollSize)
        {
            transform.position = target.transform.position + Vector3.up * scrollSize;
        }
    }
}
