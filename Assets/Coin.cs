using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter(Collider t)
    {
        if (t.GetComponent<Collider>().tag == "player")
        {

            Destroy(gameObject);


        }
    }
}
