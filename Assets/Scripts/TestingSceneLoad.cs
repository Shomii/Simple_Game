using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestingSceneLoad : MonoBehaviour
{

	public void StartScenes (string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
}
