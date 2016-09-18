using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class DrumBeat : MonoBehaviour {

	//public GameObject PlayerHands;
	private AudioSource audio;
	public float pitch = 0.1f;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.pitch = pitch;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Left Hand") {
			audio.Play();
		}

		if (other.gameObject.tag == "Right Hand") {
			audio.Play();
		}
	}
}
