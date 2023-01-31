using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 17/12/22
// Description	: On click button change scene to settings scene
//---------------------------------------------------------------------------------
public class GoSettings : MonoBehaviour
{
   public void settingsScene() {
    SceneManager.LoadScene("Settings");
   }
}
