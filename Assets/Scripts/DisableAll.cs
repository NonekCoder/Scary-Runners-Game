using UnityEngine;
using Photon.Pun;

public class DisableAll : MonoBehaviourPunCallbacks
{
    public GameObject objectToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HandTag"))
        {
            // Check if the current instance of the script is running on the local player
            if (photonView.IsMine)
            {
                // If it's the local player, disable the GameObject for all players in the network
                photonView.RPC("DisableObject", RpcTarget.AllBuffered);
            }
        }
    }

    [PunRPC]
    void DisableObject()
    {
        // Disable the specified GameObject for all players
        objectToDisable.SetActive(false);
    }
}
