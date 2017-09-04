using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Foward : MonoBehaviour {
    public float X = 1;
    public float Y = 1;
    public float Z = 1;
    // Use this for initialization


    // Update is called once per frame
    void Update () {
        transform.Translate(X, Y , Z);
    }
}
