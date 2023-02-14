using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 10/02/23
// Description	: On click button change scene to splashScreen
//---------------------------------------------------------------------------------
public class goSplashScreen : MonoBehaviour
{
   public void goSplashScene() {
    SceneManager.LoadScene("Splash Screen");
   }
}
