using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "TextBox")
        {
            Debug.Log("YOU WON!");
        }
        else if (collision.collider.tag == "FailTextBox")
        {
            Debug.Log("YOU LOST!");
        }
    }
}
