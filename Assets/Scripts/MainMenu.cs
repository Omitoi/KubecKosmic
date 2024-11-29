using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	private GameValues gv;

	public void Start()
	{
		gv = Camera.main.GetComponent<GameValues>();
	}

	public void NewGame()
	{
		SceneManager.LoadScene(gv.Nextlevel, LoadSceneMode.Single);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
