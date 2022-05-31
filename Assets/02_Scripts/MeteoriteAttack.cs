using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteAttack : MonoBehaviour
{
    [SerializeField]
    float damage = 3f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHP>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
