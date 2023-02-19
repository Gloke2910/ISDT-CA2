using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public float Timer = 0f;
    public EnemyHealth enemy;
    public GameObject dragon1;
    public GameObject dragon2;
    public GameObject dragon3;
    public GameObject dragon4;
    public GameObject dragon5;
    public void Update()
    {
        if (dragon1 == null && dragon2 == null&& dragon3 == null && dragon4 == null && dragon5 == null) {
            SceneManager.LoadScene("WinScene");
        } 
        Timer += Time.deltaTime;
        if (Timer > 180f) {
            SceneManager.LoadScene("LoseScene"); 
        }
    }
}
