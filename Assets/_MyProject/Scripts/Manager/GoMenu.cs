using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour
{
    public GameObject Menu; 
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("Hello");
            SceneManager.LoadScene("MenuScene");
        }
    }
}
