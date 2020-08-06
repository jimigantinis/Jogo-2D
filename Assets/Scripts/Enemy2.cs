using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    int wrong = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Arrow2"))
        {
            FindObjectOfType<AudioSource>().Play();
            ScoreScript.scoreValue += 10;
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
        if (col.gameObject.tag.Equals("Arrow"))
        {
            FindObjectOfType<AudioSource>().Play();
            wrong--;
        }
        if (wrong<=0)
        {
            Bow.currentAmmo = 0;
            Bow2.currentAmmo = 0;
        }
    }
}
