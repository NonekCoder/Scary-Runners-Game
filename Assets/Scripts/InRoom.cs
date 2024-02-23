using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class InRoom : MonoBehaviour
{
    public TextMeshPro Text;
    public void FixedUpdate()
    {
        if (PhotonNetwork.InRoom)
        {
            Text.text = "In Room: \n" + PhotonNetwork.CurrentRoom.Name;
        }
        else if (!PhotonNetwork.InRoom)
        {
            Text.text = "In Room: \nNOT CONNECTED";
        }
    }
}