using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class force : MonoBehaviour
{
    
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 5);
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 1, 0, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(0, -100, 0 );
        }
    }
}
