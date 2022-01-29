using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    public AudioMixer SoundSet;
    Resolution[] resolutions;
    public Dropdown resDD;
    public PostProcessProfile profile;

    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        resDD.ClearOptions();

        List<string> options = new List<string>();

        int currResIndex = 0;
        bool flag = true;
        string option;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string tempRes = resolutions[i].width + " x " + resolutions[i].height;

            for (int j = 0; j < i; j++)
            {
                if ((resolutions[j].width + " x " + resolutions[j].height) == tempRes)
                {
                    flag = false;
                }
            }

            if (flag == true)
            {
                option = tempRes;
                options.Add(option);

                if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
                {
                    currResIndex = i;
                }
            }

            flag = true;
        }

        resDD.AddOptions(options);
        resDD.value = currResIndex;
    }

    public void SetResolution(int resIndex)
    {
        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float vol)
    {
        SoundSet.SetFloat("InterviewerVol", Mathf.Log10(vol) * 20);
    }

    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

    public void SetBrightness(float bright)
    {
        Debug.Log(bright);
        profile.GetSetting<ColorGrading>().postExposure.Override(bright);
    }

    public void QuitButton()
    {
        Debug.Log("APP CLOSED!");
        Application.Quit();
    }

    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }
}
