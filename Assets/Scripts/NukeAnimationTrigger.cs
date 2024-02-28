using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Photon.Pun;

public class NukeAnimationTrigger : MonoBehaviourPunCallbacks
{
    [SerializeField] PlayableDirector cutScene;
    [SerializeField] GameObject cancel;
    [SerializeField] GameObject ready;
    [SerializeField] GameObject nukemusic;
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
        if(other.CompareTag("HandTag"))
        {
            cutScene.Play();
            Invoke(nameof(EnableReady), 90f);
        }
    }
    void EnableReady()
    {
        ready.SetActive(true);
        photonView.RPC("DisableReady", RpcTarget.AllBuffered);
    }
    [PunRPC]
    void DisableReady()
    {
        nukemusic.SetActive(false);
    }
}
