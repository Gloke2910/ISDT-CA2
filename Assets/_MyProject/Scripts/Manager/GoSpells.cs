using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 17/02/23
// Description	: On click button change scene to GameScene2 scene
//---------------------------------------------------------------------------------
public class GoSpells : MonoBehaviour
{
   public void SpellsScene() {
    SceneManager.LoadScene("GameScene 2");
   }
}
