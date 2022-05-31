using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpViewer : MonoBehaviour
{
    [SerializeField]
    PlayerHP playerHP;
    Slider HPslider;

    private void Awake()
    {
        HPslider = GetComponent<Slider>();
    }

    private void Update()
    {
        HPslider.value = playerHP.CurrentHP / playerHP.MaxHP;
    }
}
