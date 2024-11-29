using UnityEngine;

public class PlayASound : MonoBehaviour
{
	public int SoundNumber;

	private void Start()
	{
		Camera.main.GetComponent<GameSounds>().PlaySound(SoundNumber);
	}
}
