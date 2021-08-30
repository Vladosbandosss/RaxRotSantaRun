using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    int score = 0;
    public static GameManager instance;
    [SerializeField] GameObject gameOverPanel;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        ObstacleSpawn.instance.gameOver = true;
        gameOverPanel.SetActive(true);
      
    }
    public void StopScroll()
    {
       ScrolingTexture[] scrollingObg = FindObjectsOfType<ScrolingTexture>();
        foreach (var item in scrollingObg)
        {
            item.Isscrool = false;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
}
