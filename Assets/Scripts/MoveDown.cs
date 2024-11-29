using UnityEngine;

public class MoveDown : MonoBehaviour
{
	public float maxSpeed;

	private void Update()
	{
		base.transform.Translate(new Vector3(0f, 0f - maxSpeed) * Time.deltaTime, Space.World);
	}
}
