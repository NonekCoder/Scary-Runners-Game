using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class boinksfx : MonoBehaviour
{
    public PhotonView ptView;
    public AudioSource Hitsound;

    void OnTriggerEnter(Collider other)
    {
        Hitsound.Play();
    }
}
