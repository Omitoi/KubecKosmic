using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform myTarget;

	private void Start()
	{
	}

	private void Update()
	{
		if (myTarget != null)
		{
			Vector3 position = myTarget.position;
			position.z = base.transform.position.z;
			base.transform.position = position;
		}
	}
}
