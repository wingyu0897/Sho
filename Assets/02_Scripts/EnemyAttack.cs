using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    float damage = 1;
    [SerializeField]
    int scorePoint = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHP>().TakeDamage(damage);
            OnDie();
            Destroy(gameObject);
        }
    }

    public void OnDie()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().Score += scorePoint;
        Destroy(gameObject);
    }
}
