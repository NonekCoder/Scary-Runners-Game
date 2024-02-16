using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabChanger : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] GameObject name;
    [SerializeField] GameObject color;
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
        if(number==1)
        {
            color.SetActive(false);
            name.SetActive(true);
        }
        if(number==2)
        {
            color.SetActive(true);
            name.SetActive(false);
        }
    }
}
