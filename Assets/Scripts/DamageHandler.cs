using UnityEngine;

public class DamageHandler : MonoBehaviour
{
	public int health = 1;

	public float invPeriod;

	private float invTimer;

	private int correctLayer;

	private SpriteRenderer sr;

	private GameValues Gv;

	public GameObject Coin1;

	public GameObject Coin5;

	public GameObject Coin10;

	private GameObject Shield;

	private GameSounds Gs;

	private float droptimer = 10f;

	public float ScoreValue;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
		Gs = Camera.main.GetComponent<GameSounds>();
		correctLayer = base.gameObject.layer;
		sr = base.gameObject.GetComponent<SpriteRenderer>();
		if (sr == null)
		{
			sr = base.transform.GetComponentInChildren<SpriteRenderer>();
			if (sr == null)
			{
				Debug.LogError("Object '" + base.gameObject.name + "' has no sprite renderer.");
			}
		}
		if (base.gameObject.tag == "Player")
		{
			Gv.setHitpoints(health);
			invTimer = 2f;
			base.gameObject.layer = 10;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 8 && Shield == null)
		{
			Gv.Hit();
		}
		if (base.gameObject.layer == 17 && collision.gameObject.layer != 15)
		{
			TimeDrop();
		}
		if (collision.gameObject.layer != 15)
		{
			health--;
			invTimer = invPeriod;
			base.gameObject.layer = 10;
		}
	}

	private void Update()
	{
		Shield = GameObject.FindWithTag("Shield");
		if (Shield != null && base.gameObject.tag == "Player")
		{
			invTimer = 3f;
		}
		if (invTimer > 0f)
		{
			invTimer -= Time.deltaTime;
			if (invTimer <= 0f)
			{
				base.gameObject.layer = correctLayer;
				if (sr != null)
				{
					sr.enabled = true;
				}
			}
			else if (sr != null)
			{
				sr.enabled = !sr.enabled;
			}
		}
		if (droptimer == 0f)
		{
			DropCoins();
			droptimer = 10f;
		}
		if (health <= 0)
		{
			base.gameObject.layer = correctLayer;
			Die();
		}
	}

	private void Die()
	{
		Gv.AddScore(ScoreValue);
		if (base.gameObject.layer == 9)
		{
			DropCoins();
			Gs.PlaySound(5);
			Object.Destroy(base.gameObject);
		}
		else if (base.gameObject.layer != 19 && base.gameObject.layer != 16 && base.gameObject.layer != 8 && base.gameObject.layer != 14 && base.gameObject.layer != 13)
		{
			Debug.Log("My layer is: " + base.gameObject.layer);
			Object.Destroy(base.gameObject);
			Gs.PlaySound(5);
		}
		else
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void DropCoins()
	{
		float num = Random.Range(1, 101);
		float num2 = Random.Range(1, 101);
		if (num < 50f)
		{
			for (int i = 0; (float)i < num2 / 10f; i++)
			{
				Object.Instantiate(Coin1, base.transform.position, Quaternion.identity);
			}
		}
		else if (num < 80f)
		{
			for (int j = 0; (float)j < num2 / 25f; j++)
			{
				Object.Instantiate(Coin5, base.transform.position, Quaternion.identity);
			}
		}
		else
		{
			for (int k = 0; (float)k < num2 / 50f; k++)
			{
				Object.Instantiate(Coin10, base.transform.position, Quaternion.identity);
			}
		}
	}

	private void TimeDrop()
	{
		droptimer -= 1f;
	}
}
