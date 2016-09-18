using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class DrumBeat : MonoBehaviour {

	//public GameObject PlayerHands;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		 audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		Debug.Log("Hands collided with something");
		if (other.gameObject.tag == "Left Hand") {
			Debug.Log ("You hit the drum");
			audio.Play();
		}

		if (other.gameObject.tag == "Right Hand") {
			Debug.Log ("You hit the drum");
			audio.Play();
		}
	}
}
