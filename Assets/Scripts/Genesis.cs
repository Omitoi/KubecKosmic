using UnityEngine;

public class Genesis : MonoBehaviour
{
	private GameValues Gv;

	private void Start()
	{
		Gv = Camera.main.GetComponent<GameValues>();
		Gv.GetData();
	}
}
