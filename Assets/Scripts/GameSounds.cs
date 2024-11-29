using UnityEngine;

public class GameSounds : MonoBehaviour
{
	public AudioClip[] Sound;

	public void PlaySound(int index)
	{
		base.gameObject.GetComponent<AudioSource>().PlayOneShot(Sound[index]);
	}
}
