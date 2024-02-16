using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirrortoggle : MonoBehaviour
{
    [SerializeField] GameObject mirror;
    [SerializeField] int mode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        if(mode==1)
        {
            mirror.SetActive(true);
        }
        if(mode==0)
        {
            mirror.SetActive(false);
        }
    }
}
