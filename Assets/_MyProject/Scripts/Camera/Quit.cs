using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke and Zen Kiang
// Date  		: 22/12/22
// Description	: When the user clicks on the button, it quits 
//---------------------------------------------------------------------------------
public class Quit : MonoBehaviour 
{

	[SerializeField] private Button _Quit;

	protected void Start() 
	{
		_Quit.onClick.AddListener(() => {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
			Application.Quit();
		});
	}
	
	
}
