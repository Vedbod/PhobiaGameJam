using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject winState;
    public GameObject failState;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "TextBox")
        {
            Debug.Log("YOU WON!");
            winState.gameObject.SetActive(true);
        }
        else if (other.gameObject.tag == "FailTextBox")
        {
            Debug.Log("YOU LOST!");
            failState.gameObject.SetActive(true);
        }
    }
}
