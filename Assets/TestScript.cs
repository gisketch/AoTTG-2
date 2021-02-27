using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("HORI > 0");
        } else if(Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("HORI < 0");
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("Vertical > 0");
        } else if(Input.GetAxis("Vertical") < 0)
        {
            Debug.Log("Vertical < 0");
        }

        if(Input.GetAxis("HH") > 0)
        {
            Debug.Log("HH > 0");
        } else if(Input.GetAxis("HH") < 0)
        {
            Debug.Log("HH < 0");
        }

        if(Input.GetAxis("VV") > 0)
        {
            Debug.Log("VV > 0");
        } else if(Input.GetAxis("VV") < 0)
        {
            Debug.Log("VV < 0");
        }

         if(Input.GetAxis("ZL") > 0)
        {
            Debug.Log("ZL > 0");
        } else if(Input.GetAxis("ZL") < 0)
        {
            Debug.Log("ZL < 0");
        }

        if(Input.GetAxis("ZR") > 0)
        {
            Debug.Log("ZR > 0");
        } else if(Input.GetAxis("ZR") < 0)
        {
            Debug.Log("ZR < 0");
        }
    }
}
