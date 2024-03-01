using UnityEngine;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;

public class EnableAll : MonoBehaviourPunCallbacks
{
    public List<GameObject> objectToEnable;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("HandTag"))
        {
            // If it's the local player, enable the GameObject for all players in the network
            photonView.RPC("EnableObject", RpcTarget.AllBuffered);
        }
    } 

    [PunRPC]
    void EnableObject()
    {
        foreach (GameObject x in objectToEnable)
        {
            x.SetActive(true);
        }
        // Enable the specified GameObject for all players
    }
}
