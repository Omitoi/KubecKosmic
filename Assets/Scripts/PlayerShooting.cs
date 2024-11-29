using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public GameValues Gv;

	public GameObject RGBullet;

	public GameObject BGBullet;

	public GameObject YGBullet;

	public GameObject RGSpot1;

	public GameObject RGSpot11;

	public GameObject RGSpot12;

	public GameObject RGSpot2;

	public GameObject RGSpot3;

	public GameObject RGSpot4;

	public GameObject RGSpot5;

	public GameObject BGSpot1;

	public GameObject BGSpot11;

	public GameObject BGSpot12;

	public GameObject BGSpot2;

	public GameObject BGSpot3;

	public GameObject BGSpot4;

	public GameObject BGSpot5;

	public GameObject YGSpot1;

	private float fireDelay;

	private float cooldownTimer;

	public float gunType;

	public float gunLevel;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
	}

	private void FixedUpdate()
	{
		gunType = Gv.gunType;
		gunLevel = Gv.gunLevel;
		cooldownTimer -= Time.deltaTime;
		if (Input.GetButton("Fire1") && cooldownTimer <= 0f)
		{
			if (gunType == 1f)
			{
				FireRed();
			}
			if (gunType == 2f)
			{
				FireBlue();
			}
			if (gunType == 3f)
			{
				FireYellow();
			}
		}
	}

	private void FireRed()
	{
		fireDelay = 0.5f;
		if (gunLevel == 1f)
		{
			Object.Instantiate(RGBullet, RGSpot1.transform.position, RGSpot1.transform.rotation);
			cooldownTimer = fireDelay;
		}
		else if (gunLevel == 2f)
		{
			Object.Instantiate(RGBullet, RGSpot11.transform.position, RGSpot11.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot12.transform.position, RGSpot12.transform.rotation);
			cooldownTimer = fireDelay;
		}
		else if (gunLevel == 3f)
		{
			Object.Instantiate(RGBullet, RGSpot1.transform.position, RGSpot1.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot2.transform.position, RGSpot2.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot3.transform.position, RGSpot3.transform.rotation);
			cooldownTimer = fireDelay;
		}
		else if (gunLevel >= 4f)
		{
			Object.Instantiate(RGBullet, RGSpot1.transform.position, RGSpot1.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot2.transform.position, RGSpot2.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot3.transform.position, RGSpot3.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot4.transform.position, RGSpot4.transform.rotation);
			Object.Instantiate(RGBullet, RGSpot5.transform.position, RGSpot5.transform.rotation);
			cooldownTimer = fireDelay;
		}
	}

	private void FireBlue()
	{
		fireDelay = 0.25f;
		if (gunLevel == 1f)
		{
			Object.Instantiate(BGBullet, BGSpot1.transform.position, BGSpot1.transform.rotation);
			cooldownTimer = fireDelay;
		}
		if (gunLevel == 2f)
		{
			Object.Instantiate(BGBullet, BGSpot11.transform.position, BGSpot11.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot12.transform.position, BGSpot12.transform.rotation);
			cooldownTimer = fireDelay;
		}
		if (gunLevel == 3f)
		{
			Object.Instantiate(BGBullet, BGSpot2.transform.position, BGSpot2.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot3.transform.position, BGSpot3.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot4.transform.position, BGSpot4.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot5.transform.position, BGSpot5.transform.rotation);
			cooldownTimer = fireDelay;
		}
		if (gunLevel >= 4f)
		{
			Object.Instantiate(BGBullet, BGSpot1.transform.position, BGSpot1.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot2.transform.position, BGSpot2.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot3.transform.position, BGSpot3.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot4.transform.position, BGSpot4.transform.rotation);
			Object.Instantiate(BGBullet, BGSpot5.transform.position, BGSpot5.transform.rotation);
			cooldownTimer = fireDelay;
		}
	}

	private void FireYellow()
	{
		if (gunLevel == 1f)
		{
			fireDelay = 1f;
			Object.Instantiate(YGBullet, YGSpot1.transform.position, YGSpot1.transform.rotation);
			cooldownTimer = fireDelay;
		}
		if (gunLevel == 2f)
		{
			fireDelay = 0.85f;
			Object.Instantiate(YGBullet, YGSpot1.transform.position, YGSpot1.transform.rotation);
			cooldownTimer = fireDelay;
		}
		if (gunLevel == 3f)
		{
			fireDelay = 0.6f;
			Object.Instantiate(YGBullet, YGSpot1.transform.position, YGSpot1.transform.rotation);
			cooldownTimer = fireDelay;
		}
		if (gunLevel >= 4f)
		{
			fireDelay = 0.55f;
			Object.Instantiate(YGBullet, YGSpot1.transform.position, YGSpot1.transform.rotation);
			cooldownTimer = fireDelay;
		}
	}
}
