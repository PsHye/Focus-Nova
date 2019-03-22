using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class configuracionesScript : MonoBehaviour
{
    public Dropdown Qualitydrop;
    public Dropdown resolutionDropdown;
    public AudioMixer audioMixer;
    Resolution[] resolutions;
         
    void Start  ()
    {
        resolutions =  Screen.resolutions;
        resolutionDropdown.ClearOptions();
        Debug.Log("Todo limpio");
       // print(Screen.currentResolution.width + "*" + Screen.currentResolution.height);
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width  + " x " + resolutions[i].height;
            options.Add(option);

           if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
                {
                currentResolutionIndex = i;

            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height,Screen.fullScreen);
        print(Screen.currentResolution.width + "*" + Screen.currentResolution.height);
    }

    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume",volume);
    }

    public void SetQuality(int qualityIndex)
    {
        
        QualitySettings.SetQualityLevel(qualityIndex);
        print("Resolucion cambiada " + qualityIndex);
    }

    public void SetFullscreen (bool isFullScreen)
    {
       
        Screen.fullScreen = isFullScreen;
        if (isFullScreen)
            print("Fullscreen is on");
        else
            print("Fullscreen off");
    }
}
