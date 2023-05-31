using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class NetworkPlayerView : NetworkBehaviour
{
    public TextMeshProUGUI buttonCounter;
    private float amount;
    
    // Start is called before the first frame update
    void Start()
    {
        total = 0f;
        buttonCounter.text = total.ToString();
    }

    public float total
    {
        get { return amount; }
        set { amount = value; }
    }
    
    private void Update()
    {
        if (buttonCounter.text != total.ToString())
        {
            buttonCounter.text = total.ToString();
        }
    }
}
