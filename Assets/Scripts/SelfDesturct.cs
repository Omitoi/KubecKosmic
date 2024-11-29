using UnityEngine;

public class SelfDesturct : MonoBehaviour
{
	public float timer = 1f;

	private void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0f)
		{
			Object.Destroy(base.gameObject);
		}
	}
}
