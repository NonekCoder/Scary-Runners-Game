using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CancelNuke : MonoBehaviour
{
    [SerializeField] GameObject music;
    [SerializeField] GameObject cancelandkill;
    [SerializeField] GameObject ready;
    [SerializeField] PlayableDirector cutScene;
    [SerializeField] GameObject nuke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("HandTag"))
        {
            music.SetActive(false);
            cancelandkill.SetActive(false);
            ready.SetActive(false);
            cutScene.Stop();
            nuke.SetActive(false);
        }
    }
}
