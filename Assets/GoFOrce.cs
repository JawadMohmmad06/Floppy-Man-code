using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoFOrce : MonoBehaviour
{
    public GameObject start;
    public bool gameon = false;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            start.SetActive(false);
            gameon = true;
        }
            if (gameon)
        {
            rb.useGravity = true;
            rb.AddForce(0, 0, 5);
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, 1, 0, ForceMode.VelocityChange);
            }
            else
            {
                rb.AddForce(0, -100, 0);
            }
        }
        else
        {
            rb.useGravity = false;
        }
    }
}
