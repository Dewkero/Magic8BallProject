using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI answerText;

    private string[] answer =
        { "You can think I'm wrong, but that's no reason to quit thinking",
        "No neurologist in his right mind would recommend that",
        "God, you are such an idiot",
        "We all make mistakes",
        "Ask Cuddy",
        "Well it isn't lupus",
        "Get a prescription",
        "Huh.",
        "This vexes me",
        "Try killing a man with your thumb",
        "Do I get bonus points if I act like I care?",
        "Everyone lies",
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, answer.Length);
            answerText.text = answer[index];
        }
    }
}
