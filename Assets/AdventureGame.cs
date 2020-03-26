using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text TextComponet;
    [SerializeField] State startingState;
    void Start()
    {
        TextComponet.text = "Ace Alrich";
    }

    void Update()
    {

    }
}
