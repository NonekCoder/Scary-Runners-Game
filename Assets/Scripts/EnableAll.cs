using UnityEngine;
using Photon.Pun;

public class EnableAll : MonoBehaviourPunCallbacks
{
    public GameObject objectToEnable;

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
            // Check if the current instance of the script is running on the local player
            if (photonView.IsMine)
            {
                // If it's the local player, enable the GameObject for all players in the network
                photonView.RPC("EnableObject", RpcTarget.AllBuffered);
            }
        }
    } 

    [PunRPC]
    void EnableObject()
    {
        // Enable the specified GameObject for all players
        objectToEnable.SetActive(true);
    }
}
