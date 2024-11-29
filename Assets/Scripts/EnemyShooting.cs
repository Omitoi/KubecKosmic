using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
	public GameObject SPOT;

	public GameObject EnemyBullet;

	private float cooldownTimer;

	public float fireDelay = 1f;

	private Transform player;

	private void Update()
	{
		if (player == null)
		{
			GameObject gameObject = GameObject.FindWithTag("Player");
			if (gameObject != null)
			{
				player = gameObject.transform;
			}
		}
		cooldownTimer -= Time.deltaTime;
		if (cooldownTimer <= 0f && player != null && Vector3.Distance(base.transform.position, player.position) < 9f)
		{
			cooldownTimer = fireDelay;
			Fire();
		}
	}

	private void Fire()
	{
		Object.Instantiate(EnemyBullet, SPOT.transform.position, SPOT.transform.rotation);
	}
}
