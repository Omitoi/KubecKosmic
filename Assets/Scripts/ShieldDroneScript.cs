using UnityEngine;

public class ShieldDroneScript : MonoBehaviour
{
	private float cooldownTimer = 7f;

	private Transform player;

	public GameObject shield;

	public float Level;

	private GameValues Gv;

	private GameObject Shield;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
		cooldownTimer -= Gv.ShieldDroneLevel;
	}

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
		if (!(player == null))
		{
		}
	}

	private void Update()
	{
		if (Shield == null)
		{
			cooldownTimer -= Time.deltaTime;
		}
		if (cooldownTimer <= 0f)
		{
			Vector3 position = player.position;
			Shield = Object.Instantiate(shield, position, Quaternion.identity);
			Shield.transform.parent = player;
			cooldownTimer = 10f - Level;
		}
	}
}
