using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform frog;
    public float speed;
    // Update is called once per frame
    /*void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            //transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
        }
    }*/
    void LateUpdate()
    {
        transform.position += Vector3.up * Time.deltaTime * speed;
        if(frog.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, frog.position.y, transform.position.z);
        }
    }
}
