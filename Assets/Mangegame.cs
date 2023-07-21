using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mangegame : MonoBehaviour
{
    public GameObject complelvl;
    bool gameov = false;
    public GameObject lvl;
    public void CompleteLevel()
    {
        lvl.SetActive(true);
    }
    public void GameOver()
    {
        if (gameov == false)
        {

            gameov = true;
            UnityEngine.Debug.Log("over");
            Invoke("Restart", 2);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void nextlvl()
    {
        complelvl.SetActive(true);
    }
}
