using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    [SerializeField]
    Vector3 direction;


    private void Update()
    {
        transform.position = transform.position + direction.normalized * speed * Time.deltaTime;
    }

    public void MoveTo(Vector3 dir)
    {
        direction = dir;
    }
}
