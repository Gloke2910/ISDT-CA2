using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 17/02/23
// Description	: On click button change scene to GameScene scene
//---------------------------------------------------------------------------------
public class GoSwords : MonoBehaviour
{
   public void SwordsScene() {
    SceneManager.LoadScene("GameScene");
   }
}
