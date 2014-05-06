using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioClip warpExit;
	private AudioSource sounds;

	void Start()
	{
		sounds = (AudioSource)gameObject.AddComponent ("AudioSource");
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			Debug.Log("Audio Play");
			sounds.PlayOneShot(warpExit);
		}

	}
}
