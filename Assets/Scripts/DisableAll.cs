using UnityEngine;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;

public class DisableAll : MonoBehaviourPunCallbacks
{
    public List<GameObject> objectToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HandTag"))
        {
            // If it's the local player, disable the GameObject for all players in the network
            photonView.RPC("DisableObject", RpcTarget.AllBuffered);
        }
    }

    [PunRPC]
    void DisableObject()
    {
        foreach (GameObject x in objectToDisable)
        {
            x.SetActive(false);
        }
        // Disable the specified GameObject for all players
    }
}
