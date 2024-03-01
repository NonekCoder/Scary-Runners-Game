using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class KillAll : MonoBehaviourPunCallbacks
{
    public GameObject objectEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HandTag"))
        {
            // If it's the local player, disable the GameObject for all players in the network
            photonView.RPC("EnableObject", RpcTarget.AllBuffered);
            Invoke("Disable", 1f);
        }
    }
    void Disable()
    {
        photonView.RPC("DisableObject", RpcTarget.AllBuffered);
    }

    [PunRPC]
    void DisableObject()
    {
        // Disable the specified GameObject for all players
        objectEnable.SetActive(false);
    }
    void EnableObject()
    {
        // Enable the specified GameObject for all players
        objectEnable.SetActive(true);
    }
}
