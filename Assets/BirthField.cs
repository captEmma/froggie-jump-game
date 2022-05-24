using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthField : MonoBehaviour
{
    public GameObject platform;
    public int platformCount=10;
    public float width = 3f;
    public float minHeight = 0.2f;
    public float maxHeight = 1.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touch trigger");
        Vector3 spawnPos = new Vector3();
        spawnPos.y += 9;
        for (int i = 0; i < platformCount; i++)
        {
            spawnPos.y += Random.Range(minHeight, maxHeight);
            spawnPos.x = Random.Range(-width, width);
            Instantiate(platform, spawnPos, Quaternion.identity);
        }
    }
}
