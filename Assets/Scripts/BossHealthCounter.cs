using UnityEngine;

public class BossHealthCounter : MonoBehaviour
{
	private DamageHandler Dh;

	private Transform HealthBar;

	private void Start()
	{
		HealthBar = GameObject.FindGameObjectWithTag("BossHealthBar").transform;
	}

	private void Update()
	{
		try
		{
			Dh = GameObject.FindGameObjectWithTag("Boss").GetComponent<DamageHandler>();
		}
		catch
		{
		}
		if (Dh != null)
		{
			Vector3 localScale = HealthBar.localScale;
			localScale.x = (float)Dh.health / 10f;
			HealthBar.localScale = localScale;
		}
	}
}
