using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnLine : MonoBehaviour
{
    float fadeTime = 0.1f;
    SpriteRenderer spriteRen;

    private void Awake()
    {
        spriteRen = GetComponent<SpriteRenderer>();
        StartCoroutine("FadeLoop");
    }

    IEnumerator FadeLoop()
    {
        while (true)
        {
            yield return StartCoroutine(FadeEffect(1, 0));

            yield return StartCoroutine(FadeEffect(0, 1));
        }
    }

    IEnumerator FadeEffect(float start, float end)
    {
        float curTime = 0;
        float percent = 0;

        while (percent < 1)
        {
            curTime += Time.deltaTime;
            percent = curTime / fadeTime;

            Color color = spriteRen.color;
            color.a = Mathf.Lerp(start, end, percent);
            spriteRen.color = color;

            yield return null;
        }
    }
}
