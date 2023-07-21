using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        UnityEngine.Debug.Log(collision.GetComponent<Collider>().tag+"fff");
    }
}
