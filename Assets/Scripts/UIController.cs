using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	private GameValues Gv;

	public Sprite ship0;

	public Sprite ship1;

	public Sprite ship2;

	public Text Level;

	public Text Lives;

	public Text Money;

	public Text GunType;

	public Text GunLevel;

	public Text HitPoints;

	public Image One;

	public Image Two;

	public Image Three;

	public Text LevelWon;

	public Text Score;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
	}

	private void Update()
	{
		if (Gv.ShipLevel == 0)
		{
			One.sprite = ship0;
			Two.sprite = ship0;
			Three.sprite = ship0;
		}
		if (Gv.ShipLevel == 1)
		{
			One.sprite = ship1;
			Two.sprite = ship1;
			Three.sprite = ship1;
		}
		if (Gv.ShipLevel == 2)
		{
			One.sprite = ship2;
			Two.sprite = ship2;
			Three.sprite = ship2;
		}
		Level.text = Gv.CurrentLevel;
		Lives.text = "Lives";
		Money.text = "Money: " + Gv.Money;
		GunType.text = Gv.Gun;
		GunLevel.text = "Gun Level: " + Gv.gunLevel;
		HitPoints.text = "Damage left: " + Gv.Health;
		LevelWon.text = string.Empty;
		Score.text = "Score: " + Gv.Score;
		if (Gv.LevelWon)
		{
			LevelWon.text = "Level Won!";
		}
		if (Gv.GameOver)
		{
			LevelWon.text = "GameOver";
		}
	}

	public void CheckLives()
	{
		if (Gv.Lives == 2f)
		{
			Object.Destroy(Three);
		}
		if (Gv.Lives == 1f)
		{
			Object.Destroy(Two);
			Object.Destroy(Three);
		}
		if (Gv.Lives == 0f)
		{
			Object.Destroy(One);
			Object.Destroy(Two);
			Object.Destroy(Three);
		}
	}
}
