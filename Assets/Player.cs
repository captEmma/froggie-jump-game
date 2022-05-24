using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D frog;
    private float movement = 0f;
    public float speed = 10f;
    public TextMeshProUGUI score;
    private float points=0;
    public int currentScore { get; set; }
    public Animator animator;
    private bool falling=true;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        frog = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (frog.velocity.y > 0)
        {
            falling = false;
        }
        else
        {
            falling = true;
        }
        movement=Input.GetAxis("Horizontal")*speed;
        if(!falling && transform.position.y > points) //going up and reached new height
        {
            points = transform.position.y;
        }
        score.text = "SCORE: " + Mathf.Round(points).ToString();
        
        animator.SetBool("isFalling", falling);
    }

    private void FixedUpdate()
    {
        Vector2 v = frog.velocity;
        v.x = movement;
        frog.velocity = v;
    }

    public void Die()
    {
        gameManager.SetScore((int)points);
        speed = 0;
    }
    public float getPoints()
    {
        return points;
    }
    public void catchFly()
    {
        points+=5;
    }

}
