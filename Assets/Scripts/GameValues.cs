using UnityEngine;

public class GameValues : MonoBehaviour
{
	public float Lives;

	private static float _Lives;

	private static string _LastLevel;

	private static string _CurrentLevel;

	private static string _NextLevel;

	private static int _Money;

	private static int _ShipLevel;

	private static float _DamageDroneLevel;

	private static float _ShieldDroneLevel;

	private static float _gunType;

	private static string _Gun;

	private static float _gunLevel;

	private static float _Health;

	private static bool _GameOver;

	private string _Slot1;

	private string _Slot2;

	public bool Slot1taken;

	private static bool _Slot1taken;

	public bool Slot2taken;

	private static bool _Slot2taken;

	public float ShipUpgradeCost;

	public float DamageDroneUpgradeCost;

	public float ShieldDroneUpgradeCost;

	private static float _Score;

	public string LastLevel { get; set; }

	public string CurrentLevel { get; set; }

	public string Nextlevel { get; set; }

	public int Money { get; set; }

	public int ShipLevel { get; set; }

	public float DamageDroneLevel { get; set; }

	public float ShieldDroneLevel { get; set; }

	public float gunType { get; set; }

	public string Gun { get; set; }

	public float gunLevel { get; set; }

	public float Health { get; set; }

	public bool GameOver { get; set; }

	public bool LevelWon { get; set; }

	public string Slot1 { get; set; }

	public string Slot2 { get; set; }

	public float Score { get; set; }

	private void Start()
	{
		CurrentLevel = _NextLevel;
		GameOver = _GameOver;
		Lives = _Lives;
		Money = _Money;
		Score = _Score;
		Nextlevel = _NextLevel;
		ShipLevel = _ShipLevel;
		DamageDroneLevel = _DamageDroneLevel;
		ShieldDroneLevel = _ShieldDroneLevel;
		gunType = _gunType;
		gunLevel = _gunLevel;
		Slot1 = _Slot1;
		Slot2 = _Slot2;
		Slot1taken = _Slot1taken;
		Slot2taken = _Slot2taken;
		if (_LastLevel == "MainMenu")
		{
			_NextLevel = "Shop";
		}
		if (_LastLevel == "Shop")
		{
			_NextLevel = "Shop";
		}
	}

	private void Update()
	{
		Score = _Score;
		GameOver = _GameOver;
		Lives = _Lives;
		Money = _Money;
		Nextlevel = _NextLevel;
		ShipLevel = _ShipLevel;
		DamageDroneLevel = _DamageDroneLevel;
		ShieldDroneLevel = _ShieldDroneLevel;
		gunType = _gunType;
		gunLevel = _gunLevel;
		Slot1 = _Slot1;
		Slot2 = _Slot2;
		Slot1taken = _Slot1taken;
		Slot2taken = _Slot2taken;
		if (_gunType == 1f)
		{
			_Gun = "Red Gun";
		}
		else if (_gunType == 2f)
		{
			_Gun = "Blue Gun";
		}
		else
		{
			_Gun = "Yellow Gun";
		}
		Gun = _Gun;
		Health = _Health;
		if (ShieldDroneLevel == 0f)
		{
			ShieldDroneUpgradeCost = 125f;
		}
		if (ShieldDroneLevel == 1f)
		{
			ShieldDroneUpgradeCost = 100f;
		}
		if (ShieldDroneLevel == 2f)
		{
			ShieldDroneUpgradeCost = 110f;
		}
		if (ShieldDroneLevel == 3f)
		{
			ShieldDroneUpgradeCost = 120f;
		}
		if (ShieldDroneLevel == 4f)
		{
			ShieldDroneUpgradeCost = 130f;
		}
		if (ShieldDroneLevel == 5f)
		{
			ShieldDroneUpgradeCost = 140f;
		}
		if (ShieldDroneLevel == 6f)
		{
			ShieldDroneUpgradeCost = 190f;
		}
		if (DamageDroneLevel == 0f)
		{
			DamageDroneUpgradeCost = 100f;
		}
		if (DamageDroneLevel == 1f)
		{
			DamageDroneUpgradeCost = 90f;
		}
		if (DamageDroneLevel == 2f)
		{
			DamageDroneUpgradeCost = 100f;
		}
		if (DamageDroneLevel == 3f)
		{
			DamageDroneUpgradeCost = 110f;
		}
		if (DamageDroneLevel == 4f)
		{
			DamageDroneUpgradeCost = 120f;
		}
		if (DamageDroneLevel == 5f)
		{
			DamageDroneUpgradeCost = 190f;
		}
		if (ShipLevel == 0)
		{
			ShipUpgradeCost = 500f;
		}
		if (ShipLevel == 1)
		{
			ShipUpgradeCost = 750f;
		}
		if (ShipLevel == 2)
		{
			ShipUpgradeCost = 190f;
		}
	}

	public void GetData()
	{
		_Lives = 3f;
		_NextLevel = "Level1";
		_Money = 0;
		_ShipLevel = 0;
		_DamageDroneLevel = 0f;
		_ShieldDroneLevel = 0f;
		_Slot1 = "false";
		_Slot2 = "false";
		_gunType = 1f;
		_gunLevel = 1f;
		LevelWon = false;
		_GameOver = false;
		_LastLevel = string.Empty;
		_Score = 0f;
	}

	public void UpgradeGun(float Type)
	{
		if (Type == gunType)
		{
			_gunLevel += 1f;
		}
		else
		{
			_gunType = Type;
		}
	}

	public bool Died()
	{
		if (_gunLevel >= 4f)
		{
			_gunLevel -= 1f;
			_gunLevel -= 1f;
		}
		else if (_gunLevel > 1f)
		{
			_gunLevel -= 1f;
		}
		_Lives -= 1f;
		return true;
	}

	public void setHitpoints(int hits)
	{
		_Health = hits;
	}

	public void Hit()
	{
		_Health -= 1f;
	}

	public void CoinsCollect(float value)
	{
		_Money += (int)value;
		base.gameObject.GetComponent<GameSounds>().PlaySound(4);
	}

	public void setNextLevel(string TheLevel)
	{
		_NextLevel = TheLevel;
	}

	public void itisGameOver()
	{
		_GameOver = !_GameOver;
	}

	public void WonTheLevel()
	{
		LevelWon = true;
	}

	public void UpgradeShip()
	{
		_ShipLevel++;
	}

	public void UpgradeDamageDrone()
	{
		_DamageDroneLevel += 1f;
		if (_Slot1taken)
		{
			_Slot2taken = true;
		}
		else
		{
			_Slot1taken = true;
		}
	}

	public void UpgradeShieldDrone()
	{
		_ShieldDroneLevel += 1f;
		if (_Slot1taken)
		{
			_Slot2taken = true;
		}
		else
		{
			_Slot1taken = true;
		}
	}

	public void SetSlot1(string Drone)
	{
		_Slot1 = Drone;
	}

	public void SetSlot2(string Drone)
	{
		_Slot2 = Drone;
	}

	public void SpendMoney(int HowMany)
	{
		_Money -= HowMany;
	}

	public void AddScore(float HowMany)
	{
		_Score += HowMany;
	}
}
