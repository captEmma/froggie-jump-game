using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float jumpF = 10f;

    public AudioSource splat;
    private void Start()
    {
        splat = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D frog = collision.collider.GetComponent<Rigidbody2D>();
            if (frog != null)
            {
                splat.Play();
                Vector2 v = frog.velocity;
                v.y = jumpF;
                frog.velocity = v;
            }
        }

    }
}
