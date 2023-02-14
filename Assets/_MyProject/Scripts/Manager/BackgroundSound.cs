using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 17/12/22
// Description	: Script to ensure that the background audio is constant through the scenes
//---------------------------------------------------------------------------------
public class BackgroundSound : MonoBehaviour
{
    // play Global
    private static BackgroundSound instance = null;
    public static BackgroundSound Instance
    {
        get {return instance;}
    }
    void Awake()
    {
        if (instance != null && instance != this) 
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // play global end 
}
