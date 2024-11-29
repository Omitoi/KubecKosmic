using UnityEngine;

public class DamageDroneScript : MonoBehaviour
{
	private GameValues Gv;

	public float Level;

	public float cooldownTimer;

	private float MovSpeed = 5f;

	public GameObject Bullet;

	private bool left = true;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
	}

	private void Update()
	{
		Level = Gv.DamageDroneLevel;
		cooldownTimer -= Time.deltaTime;
		if (cooldownTimer <= 0f)
		{
			Object.Instantiate(Bullet, base.transform.position, base.transform.rotation);
			cooldownTimer = 6f - Level;
		}
	}

	private void OnTriggerEnter2D()
	{
		left = !left;
	}

	private void FixedUpdate()
	{
		if (left)
		{
			MoveLeft();
		}
		else
		{
			MoveRight();
		}
	}

	private void MoveRight()
	{
		base.transform.Translate(new Vector3((0f - MovSpeed) * Time.deltaTime, 0f, 0f));
	}

	private void MoveLeft()
	{
		base.transform.Translate(new Vector3(MovSpeed * Time.deltaTime, 0f, 0f));
	}
}
