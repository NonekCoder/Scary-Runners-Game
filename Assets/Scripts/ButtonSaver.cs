using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ButtonSaver : MonoBehaviour
{
    [SerializeField] public int clicked;
    [SerializeField] private PlayableDirector cutsceneDirector;
    [SerializeField] GameObject opendoor;
    [SerializeField] GameObject closedoor;
    [SerializeField] GameObject sfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked==4)
        {
            cutsceneDirector.Play();
            sfx.SetActive(true);
            Invoke("nodoor", 6f);
        }
    }
    void nodoor()
    {
        closedoor.SetActive(false);
        opendoor.SetActive(true);
        sfx.SetActive(false);
    }
}
