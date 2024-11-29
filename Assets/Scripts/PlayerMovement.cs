using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float maxSpeed;

	private float shipBoundaryRadius = 0.5f;

	private void Update()
	{
		float num = (float)Screen.width / (float)Screen.height;
		float num2 = Camera.main.orthographicSize * num;
		Vector3 position = base.transform.position;
		Vector3 vector = new Vector3(Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0f);
		position += vector;
		if (position.y + shipBoundaryRadius > Camera.main.orthographicSize)
		{
			position.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if (position.y - shipBoundaryRadius < 0f - Camera.main.orthographicSize)
		{
			position.y = 0f - Camera.main.orthographicSize + shipBoundaryRadius;
		}
		if (position.x + shipBoundaryRadius > num2)
		{
			position.x = num2 - shipBoundaryRadius;
		}
		if (position.x - 6f - shipBoundaryRadius < 0f - num2)
		{
			position.x = 0f - num2 + shipBoundaryRadius + 6f;
		}
		base.transform.position = position;
	}
}
