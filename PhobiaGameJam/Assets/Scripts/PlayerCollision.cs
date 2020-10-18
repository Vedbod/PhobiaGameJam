using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject winState;
    public GameObject failState;
    public GameObject disableLevel;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "TextBox")
        {
            Debug.Log("YOU WON!");
            disableLevel.gameObject.SetActive(false);
            winState.gameObject.SetActive(true);
        }
        else if (other.gameObject.tag == "FailTextBox")
        {
            Debug.Log("YOU LOST!");
            disableLevel.gameObject.SetActive(false);
            failState.gameObject.SetActive(true);
        }
    }
}
