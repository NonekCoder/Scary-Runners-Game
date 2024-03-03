using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ki : MonoBehaviour
{
    public Transform gorillaPlayer;
    public Transform monster;
    public Transform respawnPoint;
    public List<GameObject> mapsToDisable;
    public float delayBeforeReEnabling;
    public float timeBeforeTeleport;
    public GameObject jumpscareObject;
    public float jumpscareDuration;
    public bool isJumpscaring = true;
    float distanceToMonster;


    void Update()
    {
        distanceToMonster = Vector3.Distance(gorillaPlayer.position, monster.position);
        if(distanceToMonster<1f)
        {
            StartCoroutine(TeleportPlayer());

            if (isJumpscaring)
            {
                isJumpscaring = false;
                jumpscareObject.SetActive(true);

                Invoke("DisableJumpscare", jumpscareDuration);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("HandTag"))
        {
            StartCoroutine(TeleportPlayer());

            if (isJumpscaring)
            {
                isJumpscaring = false;
                jumpscareObject.SetActive(true);

                Invoke("DisableJumpscare", jumpscareDuration);
            }
        }
    }

    IEnumerator TeleportPlayer()
    {
        foreach (GameObject x in mapsToDisable)
        {
            x.SetActive(false);
        }
        gorillaPlayer.transform.position = respawnPoint.transform.position;

        yield return new WaitForSeconds(timeBeforeTeleport);
        foreach (GameObject x in mapsToDisable)
        {
            x.SetActive(true);
        }

    }

    private void DisableJumpscare()
    {
        jumpscareObject.SetActive(false);
        isJumpscaring = true;
    }
}
