using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool alive = true;
    Player frog;
    public int score { get; set; }

    public void Start()
    {
        frog = FindObjectOfType<Player>();
    }

    public void Awake()
    {
        score = PlayerPrefs.GetInt("score");
    }

    public void SetScore(int points)
    {
        PlayerPrefs.SetInt("score", points);
    }

    public void GameOver()
    {
        if (alive)
        {
            alive = false;
            EndGame();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("DeathScene");
    }
}
