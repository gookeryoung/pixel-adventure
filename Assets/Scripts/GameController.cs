using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public static GameController Instance;
    public GameObject gameoverPanel;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void UpdateTotalScore()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOverPanel()
    {
        gameoverPanel.SetActive(true);
    }

    
    public void RestartLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
