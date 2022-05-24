using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathField : MonoBehaviour
{
    public Player frog;
    public GameObject platform;
    public GameObject newPlatform;
    public float width = 3f;
    public float minHeight = 0.2f;
    public float maxHeight = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        frog = FindObjectOfType<Player>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 spawnPos = new Vector2(Random.Range(-width, width), 
            frog.transform.position.y + 10 + Random.Range(minHeight, maxHeight));

        if (collision.collider.tag=="Player")
        {
            FindObjectOfType<Player>().Die();
            FindObjectOfType<GameManager>().GameOver();
        }
        else
        {
            newPlatform = (GameObject)Instantiate(platform, spawnPos, Quaternion.identity);
            Debug.Log("new platform");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 spawnPos = new Vector2(Random.Range(-width, width),
            frog.transform.position.y + 10 + Random.Range(minHeight, maxHeight));

        if (collision.tag == "Player")
        {
            FindObjectOfType<Player>().Die();
            FindObjectOfType<GameManager>().GameOver();
        }
        else
        {
            newPlatform = (GameObject)Instantiate(platform, spawnPos, Quaternion.identity);
            Debug.Log("new platform");
        }
    }
}
