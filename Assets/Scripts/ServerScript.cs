using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ServerScript : MonoBehaviour
{
    public JoinRoom joinRoom;
    public string Letter;
    public string HandTag;
    // public TextMeshPro ServerText; //add REFERENCE TO THIS

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == HandTag)
        {
            if (joinRoom.codeText.text.Length < 12) 
            {
                joinRoom.codeText.text += Letter;
                // ServerText.text = joinRoom.name;
                // Debug.Log(ServerText.text);
            }
        }
    }

    private void FixedUpdate() 
    {
        // ServerText.text = joinRoom.name; 
    }
}