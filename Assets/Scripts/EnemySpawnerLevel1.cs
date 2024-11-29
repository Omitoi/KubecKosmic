using UnityEngine;

public class EnemySpawnerLevel1 : MonoBehaviour
{
	public GameObject m45;

	public GameObject m40;

	public GameObject m35;

	public GameObject m30;

	public GameObject m25;

	public GameObject m20;

	public GameObject m15;

	public GameObject m10;

	public GameObject m5;

	public GameObject zero;

	public GameObject p5;

	public GameObject p10;

	public GameObject p15;

	public GameObject p20;

	public GameObject p25;

	public GameObject p30;

	public GameObject p35;

	public GameObject p40;

	public GameObject p45;

	public GameObject trs1;

	public GameObject str1;

	public GameObject pac1;

	public GameObject fgh1;

	public GameObject chs1;

	public GameObject boss1;

	private bool isbossalive = true;

	private float timer;

	private bool spawn;

	public float TIME;

	public float TIME2;

	private GameValues gv;

	private bool Wavefeeding1;

	private GameObject ship1;

	private float fromtime1;

	private float offset1;

	private GameObject BossSensor;

	private bool BossSpawned;

	private float Endtimer = 5f;

	private void Start()
	{
		gv = Camera.main.GetComponent<GameValues>();
		gv.setNextLevel("Shop");
	}

	private void Update()
	{
		timer += Time.deltaTime;
		TIME2 = timer * 10f;
		TIME2 = (int)TIME2;
		TIME2 /= 10f;
		if (TIME2 == TIME)
		{
			spawn = false;
		}
		else
		{
			spawn = true;
		}
		TIME = timer * 10f;
		TIME = (int)TIME;
		TIME /= 10f;
		if (spawn)
		{
			if (Wavefeeding1)
			{
				if ((double)offset1 > 0.5)
				{
					if (TIME == fromtime1)
					{
						Object.Instantiate(ship1, m40.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1)
					{
						Object.Instantiate(ship1, m35.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 2f)
					{
						Object.Instantiate(ship1, m30.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 3f)
					{
						Object.Instantiate(ship1, m25.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 4f)
					{
						Object.Instantiate(ship1, m20.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 5f)
					{
						Object.Instantiate(ship1, m15.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 6f)
					{
						Object.Instantiate(ship1, m10.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 7f)
					{
						Object.Instantiate(ship1, m5.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 8f)
					{
						Object.Instantiate(ship1, zero.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 9f)
					{
						Object.Instantiate(ship1, p5.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 10f)
					{
						Object.Instantiate(ship1, p10.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 11f)
					{
						Object.Instantiate(ship1, p15.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 12f)
					{
						Object.Instantiate(ship1, p20.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 13f)
					{
						Object.Instantiate(ship1, p25.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 14f)
					{
						Object.Instantiate(ship1, p30.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 15f)
					{
						Object.Instantiate(ship1, p35.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 16f)
					{
						Object.Instantiate(ship1, p40.transform.position, m40.transform.rotation);
						Wavefeeding1 = false;
					}
				}
				else
				{
					if (TIME == fromtime1)
					{
						Object.Instantiate(ship1, m40.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1)
					{
						Object.Instantiate(ship1, m30.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 2f)
					{
						Object.Instantiate(ship1, m20.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 3f)
					{
						Object.Instantiate(ship1, m10.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 4f)
					{
						Object.Instantiate(ship1, zero.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 5f)
					{
						Object.Instantiate(ship1, p10.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 6f)
					{
						Object.Instantiate(ship1, p20.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 7f)
					{
						Object.Instantiate(ship1, p30.transform.position, m40.transform.rotation);
					}
					if (TIME == fromtime1 + offset1 * 8f)
					{
						Object.Instantiate(ship1, p40.transform.position, m40.transform.rotation);
						Wavefeeding1 = false;
					}
				}
			}
			if (TIME == 3f)
			{
				Object.Instantiate(trs1, m35.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, m25.transform.position, m40.transform.rotation);
			}
			if (TIME == 100f)
			{
				Object.Instantiate(pac1, zero.transform.position, m40.transform.rotation);
			}
			if (TIME == 7f || TIME == 9f || TIME == 71f || TIME == 73f || TIME == 78f)
			{
				Object.Instantiate(trs1, m5.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, p5.transform.position, m40.transform.rotation);
			}
			if (TIME == 8f || TIME == 72f || TIME == 77f)
			{
				Object.Instantiate(trs1, m10.transform.position, m40.transform.rotation);
				Object.Instantiate(pac1, zero.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, p10.transform.position, m40.transform.rotation);
			}
			if (TIME == 31f || TIME == 33f || TIME == 59f || TIME == 61f)
			{
				Object.Instantiate(trs1, p25.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, p35.transform.position, m40.transform.rotation);
			}
			if (TIME == 32f || TIME == 60f)
			{
				Object.Instantiate(trs1, p20.transform.position, m40.transform.rotation);
				Object.Instantiate(pac1, p30.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, p40.transform.position, m40.transform.rotation);
			}
			if (TIME == 39f || TIME == 41f || TIME == 59f || TIME == 61f)
			{
				Object.Instantiate(trs1, m25.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, m35.transform.position, m40.transform.rotation);
			}
			if (TIME == 40f || TIME == 60f)
			{
				Object.Instantiate(trs1, m20.transform.position, m40.transform.rotation);
				Object.Instantiate(pac1, m30.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, m40.transform.position, m40.transform.rotation);
			}
			if (TIME == 15f || TIME == 66f)
			{
				Object.Instantiate(fgh1, zero.transform.position, m40.transform.rotation);
			}
			if (TIME == 45f || TIME == 65f)
			{
				Object.Instantiate(fgh1, m20.transform.position, m40.transform.rotation);
				Object.Instantiate(fgh1, p20.transform.position, m40.transform.rotation);
			}
			if (TIME == 12f || TIME == 14f || TIME == 16f || TIME == 18f || TIME == 20f || TIME == 22f || TIME == 24f)
			{
				Object.Instantiate(trs1, m20.transform.position, m40.transform.rotation);
				Object.Instantiate(trs1, p20.transform.position, m40.transform.rotation);
			}
			if (TIME == 30f || TIME == 34f || TIME == 73f)
			{
				Object.Instantiate(str1, m35.transform.position, m40.transform.rotation);
				Object.Instantiate(str1, m20.transform.position, m40.transform.rotation);
			}
			if (TIME == 38f || TIME == 42f || TIME == 74f)
			{
				Object.Instantiate(str1, p35.transform.position, m40.transform.rotation);
				Object.Instantiate(str1, p20.transform.position, m40.transform.rotation);
			}
			if (TIME == 76f)
			{
				Object.Instantiate(str1, p5.transform.position, m40.transform.rotation);
				Object.Instantiate(str1, m5.transform.position, m40.transform.rotation);
			}
			if (TIME == 50f || TIME == 55f || TIME == 70f || TIME == 85f || TIME == 89f || TIME == 93f)
			{
				Object.Instantiate(chs1, m25.transform.position, m40.transform.rotation);
				Object.Instantiate(chs1, zero.transform.position, m40.transform.rotation);
				Object.Instantiate(chs1, p25.transform.position, m40.transform.rotation);
			}
			if (TIME == 52f || TIME == 56f || TIME == 72f || TIME == 83f || TIME == 87f || TIME == 91f)
			{
				Object.Instantiate(chs1, m40.transform.position, m40.transform.rotation);
				Object.Instantiate(chs1, m20.transform.position, m40.transform.rotation);
				Object.Instantiate(chs1, p20.transform.position, m40.transform.rotation);
				Object.Instantiate(chs1, p40.transform.position, m40.transform.rotation);
			}
			if (TIME == 80f)
			{
				WaveFeed(TIME, 2f, str1);
			}
			if (TIME == 115f)
			{
				BossSensor = Object.Instantiate(fgh1, zero.transform.position, m40.transform.rotation);
			}
			if (TIME > 115f && BossSensor == null)
			{
				if (!BossSpawned)
				{
					Vector3 position = zero.transform.position;
					position.y += 2f;
					boss1 = Object.Instantiate(boss1, position, boss1.transform.rotation);
					BossSpawned = true;
				}
				if (boss1 == null)
				{
					isbossalive = false;
				}
			}
		}
		if (!isbossalive)
		{
			gv.WonTheLevel();
		}
	}

	private void WaveFeed(float _fromtime, float _offset, GameObject _ship)
	{
		Wavefeeding1 = true;
		fromtime1 = _fromtime;
		offset1 = _offset;
		ship1 = _ship;
	}
}
