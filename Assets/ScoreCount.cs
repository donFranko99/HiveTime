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
        if(score == 1)
        {
            scoreText.text = score.ToString() + " PYLEK";
        }
        if (score >= 2 && score <= 4)
        {
            scoreText.text = score.ToString() + " PYLKI";
        }
        if (score >= 5 )
        {
            scoreText.text = score.ToString() + " PYLKOW";
        }

    }
}
