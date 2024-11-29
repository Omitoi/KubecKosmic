using UnityEngine;

public class GunUpgrade : MonoBehaviour
{
	public float Type;

	private GameValues Gv;

	public void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
	}

	private void OnTriggerEnter2D()
	{
		Gv.UpgradeGun(Type);
	}
}
