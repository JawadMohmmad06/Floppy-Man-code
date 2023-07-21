using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lvlcomplete : MonoBehaviour
{
    // Start is called before the first frame update
   public void nextlvlgo()
    {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        
    }
}
