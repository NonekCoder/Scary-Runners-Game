using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAll : MonoBehaviour
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
    public void OnTriggerEnter()
    {
        objectEnable.SetActive(true);
        Invoke("Disable", 1f);
    }
    void Disable()
    {
        objectEnable.SetActive(false);
    }
}
