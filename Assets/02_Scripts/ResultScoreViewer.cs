using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScoreViewer : MonoBehaviour
{
    TextMeshProUGUI textScore;
    
    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        textScore.text = "Result Score : " + PlayerPrefs.GetInt("Score", 0);
    }
}
