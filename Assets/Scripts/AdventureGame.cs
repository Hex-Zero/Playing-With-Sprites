using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text TextComponet;
    [SerializeField] State startingState;



    State state;
    void Start()
    {
        state = startingState;
        TextComponet.text = state.GetStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextState();
        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        TextComponet.text = state.GetStateStory();
    }
}
