using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
	private GameValues Gv;

	public Sprite XSign;

	public Sprite Damage;

	public Sprite Shield;

	public Sprite Ship0;

	public Sprite Ship1;

	public Sprite Ship2;

	public Text CurrentMoney;

	public Text ShipUpgradeButtonText;

	public Image ShipImage;

	public Text CurrentShipLevel;

	public Text CurrentShipHitpoints;

	public Text CurrentShipInvulTime;

	public Text CurrentDroneSlots;

	public Text NextLevelShipLevel;

	public Text NextLevelShipHitpoints;

	public Text NextLevelShipInvulTime;

	public Text NextLevelShipDroneSlots;

	public Text ShipUpgradeCost;

	public Image Slot1;

	public Image Slot2;

	public Text Slot1Drone;

	public Text Slot1DroneAbilities;

	public Text Slot2Drone;

	public Text Slot2DroneAbilities;

	public Text DamageDroneCost;

	public Text DamageDroneButtonText;

	public Text DamageDroneCurrentLevel;

	public Text ShieldDroneCost;

	public Text ShieldDroneButtonText;

	public Text ShieldDroneCurrentLevel;

	private int SUC;

	private int DDUC;

	private int SDUC;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
		if (Gv.LastLevel == "Level1")
		{
			Gv.setNextLevel("Level2");
		}
		if (Gv.LastLevel == "Level2")
		{
			Gv.setNextLevel("Level3");
		}
	}

	private void Update()
	{
		CurrentMoney.text = "Money: " + Gv.Money;
		if (Gv.ShieldDroneLevel <= 5f)
		{
			ShieldDroneCost.text = "Cost: " + Gv.ShieldDroneUpgradeCost + " Money";
		}
		if (Gv.ShieldDroneLevel == 6f)
		{
			ShieldDroneCost.text = string.Empty;
		}
		if (Gv.DamageDroneLevel <= 4f)
		{
			DamageDroneCost.text = "Cost: " + Gv.DamageDroneUpgradeCost + " Money";
		}
		if (Gv.DamageDroneLevel == 5f)
		{
			DamageDroneCost.text = string.Empty;
		}
		if (!Gv.Slot1taken)
		{
			Slot1.sprite = XSign;
			if (Gv.ShipLevel > 0)
			{
				Slot1Drone.text = "Free drone slot";
			}
			else
			{
				Slot1Drone.text = "No drone slots";
			}
			Slot1DroneAbilities.text = string.Empty;
		}
		if (!Gv.Slot2taken)
		{
			Slot2.sprite = XSign;
			if (Gv.ShipLevel == 2)
			{
				Slot2Drone.text = "Free drone slot";
			}
			else
			{
				Slot2Drone.text = "No drone slots";
			}
			Slot2DroneAbilities.text = string.Empty;
		}
		if (Gv.Slot1 == "ShieldDrone")
		{
			Slot1.sprite = Shield;
			Slot1Drone.text = "Shield drone level " + Gv.ShieldDroneLevel;
			Slot1DroneAbilities.text = "Shield cooldown: " + (7f - Gv.ShieldDroneLevel) + "s";
		}
		if (Gv.Slot1 == "DamageDrone")
		{
			Slot1.sprite = Damage;
			Slot1Drone.text = "Damage drone level " + Gv.DamageDroneLevel;
			Slot1DroneAbilities.text = "Fire cooldown: " + (6f - Gv.DamageDroneLevel) + "s";
		}
		if (Gv.Slot2 == "ShieldDrone")
		{
			Slot2.sprite = Shield;
			Slot2Drone.text = "Shield drone level " + Gv.ShieldDroneLevel;
			Slot2DroneAbilities.text = "Shield cooldown: " + (7f - Gv.ShieldDroneLevel) + "s";
		}
		if (Gv.Slot2 == "DamageDrone")
		{
			Slot2.sprite = Damage;
			Slot2Drone.text = "Damage drone level " + Gv.DamageDroneLevel;
			Slot2DroneAbilities.text = "Fire cooldown: " + (6f - Gv.DamageDroneLevel) + "s";
		}
		if (Gv.ShipLevel == 0)
		{
			ShipImage.sprite = Ship0;
			CurrentShipLevel.text = "Level 0";
			CurrentShipHitpoints.text = "Hitpoints: 2";
			CurrentShipInvulTime.text = "Invulnerability time: 1s";
			CurrentDroneSlots.text = "Drone Slots: 0";
			NextLevelShipLevel.text = "Next Ship: Level1";
			NextLevelShipHitpoints.text = "Hitpoints: 3";
			NextLevelShipInvulTime.text = "Invulnerability time: 1.5s";
			NextLevelShipDroneSlots.text = "Drone Slots: 1";
			ShipUpgradeCost.text = "Cost: " + Gv.ShipUpgradeCost + " Money";
		}
		if (Gv.ShipLevel == 1)
		{
			ShipImage.sprite = Ship1;
			CurrentShipLevel.text = "Level 1";
			CurrentShipHitpoints.text = "Hitpoints: 3";
			CurrentShipInvulTime.text = "Invulnerability time: 1.5s";
			CurrentDroneSlots.text = "Drone Slots: 1";
			NextLevelShipLevel.text = "Next Ship: Level2";
			NextLevelShipHitpoints.text = "Hitpoints: 4";
			NextLevelShipInvulTime.text = "Invulnerability time: 2s";
			NextLevelShipDroneSlots.text = "Drone Slots: 2";
			ShipUpgradeCost.text = "Cost: " + Gv.ShipUpgradeCost + " Money";
		}
		if (Gv.ShipLevel == 2)
		{
			ShipImage.sprite = Ship2;
			CurrentShipLevel.text = "Level 2";
			CurrentShipHitpoints.text = "Hitpoints: 4";
			CurrentShipInvulTime.text = "Invulnerability time: 2s";
			CurrentDroneSlots.text = "Drone Slots: 2";
			NextLevelShipLevel.text = "Fully Upgraded";
			NextLevelShipHitpoints.text = string.Empty;
			NextLevelShipInvulTime.text = string.Empty;
			NextLevelShipDroneSlots.text = string.Empty;
			ShipUpgradeCost.text = string.Empty;
		}
		if (Gv.DamageDroneLevel == 6f)
		{
			DamageDroneButtonText.text = string.Empty;
		}
	}

	public void Continue()
	{
		SceneManager.LoadScene("Level2", LoadSceneMode.Single);
	}

	public void ShieldDroneBuyRequest()
	{
		if (Gv.Money <= (int)Gv.ShieldDroneUpgradeCost)
		{
			return;
		}
		if (Gv.ShieldDroneLevel == 0f && Gv.ShipLevel > 0 && Gv.ShieldDroneLevel < 6f && Gv.ShipLevel > 0)
		{
			if (!Gv.Slot1taken)
			{
				ShieldDroneButtonText.text = "upgrade";
				Gv.UpgradeShieldDrone();
				Gv.SpendMoney((int)Gv.ShieldDroneUpgradeCost);
				Gv.SetSlot1("ShieldDrone");
			}
			else if (Gv.ShipLevel == 2)
			{
				ShieldDroneButtonText.text = "upgrade";
				Gv.UpgradeShieldDrone();
				Gv.SpendMoney((int)Gv.ShieldDroneUpgradeCost);
				Gv.SetSlot2("ShieldDrone");
			}
		}
		else if (Gv.ShieldDroneLevel > 0f && Gv.ShieldDroneLevel < 6f && (Gv.Slot1 == "ShieldDrone" || Gv.Slot2 == "ShieldDrone"))
		{
			Gv.UpgradeShieldDrone();
			Gv.SpendMoney((int)Gv.ShieldDroneUpgradeCost);
		}
	}

	public void DamageDroneBuyRequest()
	{
		if (Gv.Money <= (int)Gv.DamageDroneUpgradeCost || !(Gv.DamageDroneLevel < 5f) || Gv.ShipLevel <= 0)
		{
			return;
		}
		Debug.Log("Prvni");
		if (Gv.DamageDroneLevel == 0f && Gv.ShipLevel > 0)
		{
			Debug.Log("Druhy");
			if (!Gv.Slot1taken)
			{
				Debug.Log("Treti");
				DamageDroneButtonText.text = "upgrade";
				Gv.UpgradeDamageDrone();
				Gv.SpendMoney((int)Gv.DamageDroneUpgradeCost);
				Gv.SetSlot1("DamageDrone");
				Debug.Log("1");
			}
			else if (Gv.ShipLevel == 2)
			{
				DamageDroneButtonText.text = "upgrade";
				Gv.UpgradeDamageDrone();
				Gv.SpendMoney((int)Gv.DamageDroneUpgradeCost);
				Gv.SetSlot2("DamageDrone");
				Debug.Log("2");
			}
		}
		else if (Gv.DamageDroneLevel > 0f && Gv.DamageDroneLevel < 6f && (Gv.Slot1 == "DamageDrone" || Gv.Slot2 == "DamageDrone"))
		{
			Gv.UpgradeDamageDrone();
			Gv.SpendMoney((int)Gv.DamageDroneUpgradeCost);
			Debug.Log("3");
		}
	}

	public void ShipUpgradeUpgradeRequest()
	{
		if ((float)Gv.Money > Gv.ShipUpgradeCost && Gv.ShipLevel < 2)
		{
			Gv.UpgradeShip();
			Gv.SpendMoney((int)Gv.ShipUpgradeCost);
			Debug.Log(Gv.ShipUpgradeCost);
		}
	}
}
