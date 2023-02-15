using UnityEngine;
//using DentadPixel;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//---------------------------------------------------------------------------------
// Author		: Gabriel Loke
// Date  		: 17/12/22
// Description	: This is where you write a summary of what the role of this file.
// Canvas [Order in Layer] is set to 999 so will block all
// FadeScreen is set 0.11 in PosZ, within default XR Main Camera Clipping Planes.
//---------------------------------------------------------------------------------
public class FadeCamera : MonoBehaviour
{
	#region Variables
	//===================
	// Private Variables
	//===================
	[SerializeField] private RectTransform _fadeScreenRectTransform;
	[SerializeField] private Button StartGame;
	[SerializeField] private CanvasGroup _mainMenuPanel;
	[Header("Fade Settings")]
	[SerializeField] [Range(0.1f, 3.0f)] private float _fadeInTime = 1.0f;
	[SerializeField] [Range(0.1f, 3.0f)] private float _fadeOutTime = 1.0f;
	#endregion

	#region Unity Methods

	protected void Start()
	{
		Debug.Log("test");
			StartGame.onClick.AddListener(() =>
			{
				Debug.Log("test");
					//For testing the Fade in the out only. Can remove or comment out.
					var seq = LeanTween.sequence();
					seq.append(1f); // delay everthing 1 second
					seq.append(() =>
					{ // fire an event
					FadeMenu();
					});
					seq.append(1f); // delay everthing 1 second
					seq.append(() =>
					{ // fire an event
					FadeOutCam();
					});
					seq.append(2f); // delay everything 2 second
					seq.append(() =>
					{ // fire an event
					FadeInCam();
					});
			
			});
	}
	/*public void Update ()
	{
		StartGame.onClick.AddListener(() =>
			{
				Debug.Log("test");
					//For testing the Fade in the out only. Can remove or comment out.
					var seq = LeanTween.sequence();
					seq.append(1f); // delay everthing 1 second
					seq.append(() =>
					{ // fire an event
					FadeMenu();
					});
					seq.append(1f); // delay everthing 1 second
					seq.append(() =>
					{ // fire an event
					FadeOutCam();
					});
					seq.append(2f); // delay everything 2 second
					seq.append(() =>
					{ // fire an event
					FadeInCam();
					});
			
			});
	}*/
	#endregion

	#region Own Methods

	// FadeInCam() and FadeOutCam() can be used to prevent user looking through objects and walls using triggers

	private void FadeInCam()
    {
		LeanTween.alpha(_fadeScreenRectTransform, 0f, _fadeInTime);
	}

	private void FadeOutCam()
    {
		LeanTween.alpha(_fadeScreenRectTransform, 1f, _fadeOutTime).setOnComplete(Completete);

		// Write some logic to jump to other scene if necessary.
	}

	private void Completete()
    {
		SceneManager.LoadScene("GameScene 2");
    }

	private void FadeMenu()
    {
		LeanTween.alphaCanvas(_mainMenuPanel, 0f, 1f);
	}
	#endregion
}