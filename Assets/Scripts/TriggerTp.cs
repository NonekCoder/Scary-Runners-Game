using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTp : MonoBehaviour
{
    public Transform gorillaPlayer;
    public Transform tpPoint;
    public List<GameObject> mapsToDisable;
    public float timeBeforeTeleport;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per fram
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandTag"))
        {
            StartCoroutine(Tp());
        }
    }
    IEnumerator Tp()
    {
        foreach (GameObject x in mapsToDisable)
        {
            x.SetActive(false);
        }
        gorillaPlayer.transform.position = tpPoint.transform.position;
        yield return new WaitForSeconds(timeBeforeTeleport);

        foreach (GameObject x in mapsToDisable)
        {
            x.SetActive(true);
        }
    }
}
