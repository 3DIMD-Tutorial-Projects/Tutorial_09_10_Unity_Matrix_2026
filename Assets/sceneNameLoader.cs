using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneNameLoader : MonoBehaviour
{
	public string sceneName;
	public void LoadSceneByName()
	{
		SceneManager.LoadScene(sceneName);
	}
}
