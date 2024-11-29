using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTimer : MonoBehaviour
{
	private GameValues Gv;

	private float endtimer = 5f;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
	}

	private void Update()
	{
		if (Gv.LevelWon)
		{
			endtimer -= Time.deltaTime;
			if (endtimer < 0f)
			{
				SceneManager.LoadScene(Gv.Nextlevel, LoadSceneMode.Single);
			}
		}
		if (Gv.GameOver)
		{
			endtimer -= Time.deltaTime;
			if (endtimer < 0f)
			{
				SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
			}
		}
	}
}
