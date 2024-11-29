using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
	public GameObject Ship0;

	public GameObject Ship1;

	public GameObject Ship2;

	public UIController UI;

	private GameObject playerInstance;

	private GameValues Gv;

	private GameSounds Gs;

	private float respawnTimer;

	private float numLives;

	private float ShipLevel;

	private bool notplayedsound = true;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
		Gs = Camera.main.GetComponent<GameSounds>();
		numLives = Gv.Lives;
		ShipLevel = Gv.ShipLevel;
		SpawnPlayer();
	}

	private void SpawnPlayer()
	{
		if (ShipLevel == 0f)
		{
			playerInstance = Object.Instantiate(Ship0, base.transform.position, Quaternion.identity);
		}
		if (ShipLevel == 1f)
		{
			playerInstance = Object.Instantiate(Ship1, base.transform.position, Quaternion.identity);
		}
		if (ShipLevel == 2f)
		{
			playerInstance = Object.Instantiate(Ship2, base.transform.position, Quaternion.identity);
		}
		respawnTimer = 2f;
	}

	private void Update()
	{
		numLives = Gv.Lives;
		UI.CheckLives();
		if (playerInstance == null && numLives > 0f)
		{
			respawnTimer -= Time.deltaTime;
			if (respawnTimer <= 0f)
			{
				Gv.Died();
				SpawnPlayer();
				Gs.PlaySound(6);
			}
		}
		else if (playerInstance == null && numLives == 0f)
		{
			if (notplayedsound)
			{
				Gv.itisGameOver();
			}
			playsound(7);
		}
		else
		{
			notplayedsound = true;
		}
	}

	private void playsound(int index)
	{
		if (notplayedsound)
		{
			Gs.PlaySound(index);
			notplayedsound = !notplayedsound;
		}
	}
}
