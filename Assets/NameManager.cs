using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NameManager : MonoBehaviour
{
    public GameManager game;
    private int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        game = FindObjectOfType<GameManager>();
        score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
