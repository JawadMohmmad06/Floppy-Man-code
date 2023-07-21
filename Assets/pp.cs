using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class pp : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI cointxt;
    public GoFOrce move;
     public TextMeshProUGUI newhigh;
    public TextMeshProUGUI oldhigh;
    void OnCollisionEnter(Collision cl)
    {
        if (cl.collider.tag == "Build")
        {
            FindObjectOfType<Mangegame>().GameOver();
            move.enabled = false;
            UnityEngine.Debug.Log("yee");

        }

    }
    public void OnTriggerEnter(Collider t) {
        if (t.GetComponent<Collider>().tag == "COIN")
        {


            coin++;
            cointxt.SetText("Coin: " + coin.ToString());
           
        }

}


}
