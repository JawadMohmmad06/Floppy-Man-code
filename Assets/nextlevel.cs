using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class nextlevel : MonoBehaviour
{
    public pp player;
    public TextMeshProUGUI newhigh;
    public TextMeshProUGUI oldhigh;
    public static int totalcoin = 0;
    public void OnTriggerEnter(Collider t)
    {
        if (t.GetComponent<Collider>().tag == "player")
        {
            FindObjectOfType<Mangegame>().nextlvl();
            UnityEngine.Debug.Log("done");
            desplay();


        }
    }
    public void desplay()
    {
        totalcoin = totalcoin + player.coin;

        int hs = PlayerPrefs.GetInt("Score", 0);
        if (totalcoin > hs)
        {
            PlayerPrefs.SetInt("Score", totalcoin);
            newhigh.SetText("New HighScore " + totalcoin.ToString());
            oldhigh.SetText("");

        }
        else
        {
            newhigh.SetText("Your Score " + totalcoin);
            oldhigh.SetText("High Score " + hs.ToString());
        }
    }
}
