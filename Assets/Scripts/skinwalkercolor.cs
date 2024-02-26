using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;
using TMPro;

public class skinwalkercolor : MonoBehaviour
{


    public float Reds;
    public float Blues;
    public float Greens;
    float TrueReds;
    float TrueBlues;
    float TrueGreens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        TrueReds = Reds / 10;
        TrueBlues = Blues / 10;
        TrueGreens = Greens / 10;

        Color myColour = new Color(TrueReds, TrueBlues, TrueGreens);
        PhotonVRManager.SetColour(myColour);
    }

}
