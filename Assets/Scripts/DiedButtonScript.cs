using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiedButtonScript : MonoBehaviour
{
    public void Respawn()
    {
    SceneManager.LoadScene("Starting Menu");
    }
    public void Quit()
    {
    SceneManager.LoadScene("QuitSceen");
    }
}
