using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fundo : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("CLAITON");
            SceneManager.LoadScene(1);
        }
    }
}
