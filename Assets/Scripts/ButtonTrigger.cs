using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : ButtonSaver
{
    public ButtonSaver saver;
    [SerializeField] GameObject enabled;
    [SerializeField] GameObject disabled;
    public bool isClicked;
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
        if (!isClicked)
        {
            saver.clicked += 1;
            enabled.SetActive(true);  
            isClicked=true;
            disabled.SetActive(false);
        }
    }
}
