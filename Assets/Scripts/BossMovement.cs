using UnityEngine;

public class BossMovement : MonoBehaviour
{
	private bool Up;

	private bool Right;

	private bool going;

	public float positionY;

	public float maxSpeed;

	private void Start()
	{
	}

	private void Update()
	{
		if (going)
		{
			if (Up)
			{
				base.transform.Translate(new Vector3(0f, 0f - maxSpeed) * Time.deltaTime, Space.World);
			}
			else
			{
				base.transform.Translate(new Vector3(0f, maxSpeed) * Time.deltaTime, Space.World);
			}
			if (Right)
			{
				base.transform.Translate(new Vector3(0f - maxSpeed, 0f) * Time.deltaTime, Space.World);
			}
			else
			{
				base.transform.Translate(new Vector3(maxSpeed, 0f) * Time.deltaTime, Space.World);
			}
		}
		else if (base.transform.position.y > positionY)
		{
			base.transform.Translate(new Vector3(0f, 0f - maxSpeed) * Time.deltaTime, Space.World);
		}
		else
		{
			going = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 15 && collision.tag == "up&down")
		{
			Up = !Up;
		}
		if (collision.gameObject.layer == 15 && collision.tag == "right&left")
		{
			Right = !Right;
		}
	}

	public void SetOn()
	{
		going = true;
	}
}
