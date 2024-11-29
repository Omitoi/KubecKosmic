using UnityEngine;

public class FacesPlayer : MonoBehaviour
{
	public float rotSpeed;

	public float searchDistance;

	private Transform player;

	private void Update()
	{
		if (player == null)
		{
			GameObject gameObject = GameObject.FindWithTag("Player");
			if (gameObject != null)
			{
				player = gameObject.transform;
			}
		}
		if (!(player == null) && Vector3.Distance(base.transform.position, player.position) < searchDistance)
		{
			Vector3 vector = player.position - base.transform.position;
			vector.Normalize();
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f - 90f;
			Quaternion to = Quaternion.Euler(0f, 0f, z);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, to, rotSpeed * Time.deltaTime);
		}
	}
}
