using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{
    public Image trunk;
    public Image seat;
    public Image gauge;
    public Image wheel;
    public Image panelBG;
    public Color foundColor;
    public Color winningColor;

    private bool t;
    private bool s;
    private bool g;
    private bool w;

    private void Start()
    {
        t = false;
        s = false;
        g = false;
        w = false;
    }

    private void Update()
    {
        if (t && s && g && w)
        {
            this.foundEverything();
        }
    }

    // Start is called before the first frame update
    public void OnTrunkFound()
    {
        trunk.color = foundColor;
        t = true;
    }
    
    public void OnSeatFound()
    {
        seat.color = foundColor;
        s = true;
    }
    
    public void OnGaugeFound()
    {
        gauge.color = foundColor;
        g = true;
    }
    
    public void OnWheelFound()
    {
        wheel.color = foundColor;
        w = true;
    }

    public void foundEverything()
    {
        panelBG.color = winningColor;
    }
    
    
}
