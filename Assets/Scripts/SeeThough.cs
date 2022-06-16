using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThough : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().material.renderQueue = 3003; 
    }
}
