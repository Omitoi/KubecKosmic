using UnityEngine;

public class DronesSpawner : MonoBehaviour
{
	private GameValues Gv;

	public GameObject DamageDrone;

	public GameObject ShieldDrone;

	private Transform player;

	private GameObject Drone;

	private bool ShieldOn;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
		if (Gv.DamageDroneLevel >= 1f)
		{
			Object.Instantiate(DamageDrone, base.gameObject.transform.position, base.gameObject.transform.rotation);
		}
		if (Gv.ShieldDroneLevel >= 1f)
		{
			ShieldOn = true;
			GameObject gameObject = GameObject.FindWithTag("Player");
			if (gameObject != null)
			{
				player = gameObject.transform;
			}
		}
	}

	private void Update()
	{
		if (ShieldOn && Drone == null && player == null)
		{
			GameObject gameObject = GameObject.FindWithTag("Player");
			if (gameObject != null)
			{
				player = gameObject.transform;
				Drone = Object.Instantiate(ShieldDrone, player);
			}
		}
	}
}
