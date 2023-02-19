using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 18/02/23
// Description	: saves player location
//---------------------------------------------------------------------------------


public class PlayerPref : MonoBehaviour
{
    public float x,y,z;

    public void Save()
    {   
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }

    public void Load()
    {
        PlayerPrefs.GetFloat("x", x);
        PlayerPrefs.GetFloat("y", y);
        PlayerPrefs.GetFloat("z", z);

        Vector3 LoadPosition = new Vector3(x,y,z);
        transform.position = LoadPosition;
    }
}