using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(10, 14)][SerializeField] string questionText;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return questionText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    } 
}
