using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+ + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // AHORA VA EL CODIGO DEL MENU DE OPCIONES, CONFIGURACION, ETC.

    public void SetVolume(float volume)
    {
        Debug.Log(volume);
    }
}
