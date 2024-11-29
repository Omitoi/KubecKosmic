using UnityEngine;

public class ThrowACoin : MonoBehaviour
{
	private Rigidbody2D rb;

	private void Start()
	{
		rb = base.gameObject.GetComponent<Rigidbody2D>();
		rb.AddForce(new Vector3(Random.Range(1, 10), 0f - Mathf.Pow(Random.Range(1, 10), 2f)));
	}
}
