using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 10;
    float currentHP;
    public float CurrentHP => currentHP;
    public float MaxHP => maxHP;
    SpriteRenderer spriteRen;
    PlayerController playerController;

    private void Awake()
    {
        currentHP = maxHP;
        spriteRen = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        StopCoroutine("HitColor");
        StartCoroutine("HitColor");

        if (currentHP <= 0)
        {
            playerController.Die();
        }
    }

    IEnumerator HitColor()
    {
        spriteRen.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRen.color = Color.white;
    }
}
