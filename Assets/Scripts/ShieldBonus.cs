using UnityEngine;

public class ShieldBonus : MonoBehaviour
{
	private Transform player;

	private GameObject Shield;

	public GameObject shield;

	private void FixedUpdate()
	{
		if (player == null)
		{
			GameObject gameObject = GameObject.FindWithTag("Player");
			if (gameObject != null)
			{
				player = gameObject.transform;
			}
		}
		if (player == null)
		{
			return;
		}
		if (Shield == null)
		{
			GameObject gameObject2 = GameObject.FindWithTag("Shield");
			if (gameObject2 != null)
			{
				Shield = gameObject2;
			}
		}
		if (!(Shield == null))
		{
		}
	}

	private void ShieldOn()
	{
		if (Shield == null)
		{
			Vector3 position = player.position;
			Shield = Object.Instantiate(shield, position, Quaternion.identity);
			Shield.transform.parent = player;
			player.GetComponent<DamageHandler>().health++;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		ShieldOn();
	}
}
