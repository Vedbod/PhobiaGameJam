using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameText : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;


    State state;
    

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();
        int answer = playerMovement.answer;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    int stateAnswer;
    private void ManageState()
    {
       var nextStates = state.GetNextStates();
        
       if (stateAnswer == 0)
       {
           state = nextStates[0];
       }

       else if (stateAnswer == 1)   
       {
           state = nextStates[1];
       }
       textComponent.text = state.GetStateStory();
       
    }
}
