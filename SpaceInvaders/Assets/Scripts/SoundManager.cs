using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance;

	public AudioClip AlienBuzz1;
	public AudioClip AlienBuzz2;
	public AudioClip AlienDies;
	public AudioClip bulletFire;
	public AudioClip shipExplosion;

	private AudioSource soundEffectAudio;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;		
		} else if (Instance != this) {
			Destroy (gameObject);
		}

		AudioSource theSource = GetComponent<AudioSource> ();
		soundEffectAudio = theSource;
	}
	
	public void PlayOneShot(AudioClip clip){
		soundEffectAudio.PlayOneShot (clip);
	}
}
