using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public static GameController Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void UpdateTotalScore()
    {
        scoreText.text = totalScore.ToString();
    }
}
