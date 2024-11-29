using UnityEngine;

public class BonusDrop : MonoBehaviour
{
	public GameObject RedUpgrade;

	public GameObject BlueUpgrade;

	public GameObject YellowUpgrade;

	public GameObject ShieldBonus;

	private GameObject Shield;

	private int ran;

	private bool drop;

	private void Update()
	{
		Shield = GameObject.FindWithTag("Shield");
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!drop && collision.gameObject.layer != 15)
		{
			Debug.Log("trigger");
			if (Shield == null)
			{
				ran = Random.Range(1, 5);
			}
			else
			{
				ran = Random.Range(1, 4);
			}
			Vector3 position = base.gameObject.transform.position;
			if (ran == 1)
			{
				Object.Instantiate(RedUpgrade, position, Quaternion.identity);
			}
			if (ran == 2)
			{
				Object.Instantiate(BlueUpgrade, position, Quaternion.identity);
			}
			if (ran == 3)
			{
				Object.Instantiate(YellowUpgrade, position, Quaternion.identity);
			}
			if (ran == 4)
			{
				Object.Instantiate(ShieldBonus, position, Quaternion.identity);
			}
			drop = true;
		}
	}
}
