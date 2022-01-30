using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static ScoreCount instance;

    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " PYLKOW";
    }

    public void ScorePoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " PYLKOW";
    }
}
