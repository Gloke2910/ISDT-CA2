using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 10/02/23
// Description	: change settings such as audio etc
//---------------------------------------------------------------------------------
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}