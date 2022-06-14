using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    
    public void BtnNewScene()
    {
        SceneManager.LoadScene("Level 1");
    }
    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     if(col.gameObject.tag == "EndWin")
    //     {
    //         SceneManager.LoadScene("Level 2");
    //     }
    // }
}
