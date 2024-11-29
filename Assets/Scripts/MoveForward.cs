using UnityEngine;

public class MoveForward : MonoBehaviour
{
	public float maxSpeed = 10f;

	private void Update()
	{
		Vector3 position = base.transform.position;
		Vector3 vector = new Vector3(0f, maxSpeed * Time.deltaTime, 0f);
		position += base.transform.rotation * vector;
		base.transform.position = position;
	}
}
