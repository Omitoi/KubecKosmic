using UnityEngine;

public class CoinsCollection : MonoBehaviour
{
	public float Value;

	private GameValues Gv;

	public void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
	}

	private void OnTriggerEnter2D()
	{
		Gv.CoinsCollect(Value);
	}
}
