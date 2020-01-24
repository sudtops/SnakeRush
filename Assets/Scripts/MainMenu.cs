using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void OnPlayHandler()
	{
		Debug.Log("SceneLoaded");
		SceneManager.LoadScene(1);		
	}

	public void OnExitHandler()
	{
		Application.Quit();
	}
}
