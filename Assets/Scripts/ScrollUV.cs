using UnityEngine;

public class ScrollUV : MonoBehaviour
{
	public float speed;

	private void Update()
	{
		MeshRenderer component = GetComponent<MeshRenderer>();
		Material material = component.material;
		Vector2 mainTextureOffset = material.mainTextureOffset;
		mainTextureOffset.y += Time.deltaTime / speed;
		material.mainTextureOffset = mainTextureOffset;
	}
}
