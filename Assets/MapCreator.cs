using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject platform, boost, fly;
    public int platformCount=10; //make this private after testing
    public float width = 3f;
    public float minHeight = 0.2f;
    public float maxHeight = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 platPos = new Vector3();
        Vector3 flyPos = new Vector3();
        for (int i=0; i<platformCount; i++)
        {
            if (Random.Range(0, 15) == 0)
            {
                platPos.y += Random.Range(minHeight, maxHeight);
                platPos.x = Random.Range(-width, width);
                Instantiate(boost, platPos, Quaternion.identity);
            }
            else
            {
                platPos.y += Random.Range(minHeight, maxHeight);
                platPos.x = Random.Range(-width, width);
                Instantiate(platform, platPos, Quaternion.identity);
            }
            flyPos.y += Random.Range(minHeight, maxHeight);
            if (Random.Range(0, 20) == 0)
            {
                flyPos.x = Random.Range(-width, width); ;
                Instantiate(fly, flyPos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
