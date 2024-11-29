using UnityEngine;

public class FighterController : MonoBehaviour
{
	public float maxSpeed;

	public float positionY;

	private void Update()
	{
		if (base.transform.position.y > positionY)
		{
			base.transform.Translate(new Vector3(0f, 0f - maxSpeed) * Time.deltaTime, Space.World);
		}
	}
}
