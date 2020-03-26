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

    }
}
