using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBehaviour : MonoBehaviour
{
    public Player frog;
    public GameObject fly;
    public AudioSource splat;
    // Start is called before the first frame update
    void Start()
    {
        frog = FindObjectOfType<Player>();
        splat = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        splat.Play();
        frog.catchFly();
        Destroy(gameObject);
    }

}
