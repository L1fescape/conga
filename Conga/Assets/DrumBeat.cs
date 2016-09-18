using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class DrumBeat : MonoBehaviour {

	private AudioSource audio;
	public float pitch = 0.1f;

	public GameObject paintSpotPreFab;
	public string wall;

	float getRandomRotation () {
		return (Random.value * 90) - 45;
	}

	void PaintFrontWall() {
		float frontPositionX = (Random.value * 10) - 5;
		float frontPositionY = (Random.value * 10);

		Instantiate(paintSpotPreFab, new Vector3(frontPositionX, frontPositionY, 4.99f), Quaternion.Euler(getRandomRotation(), 90, -90));
	}
		
	void PaintLeftWall() {
		float leftPositionY = (Random.value * 10);
		float leftPositionZ = (Random.value * 10) - 5;

		Instantiate(paintSpotPreFab, new Vector3(-4.99f, leftPositionY, leftPositionZ), Quaternion.Euler(getRandomRotation(), 0, -90));
	}
		
	void PaintRightWall() {
		float rightPositionY = (Random.value * 10);
		float rightPositionZ = (Random.value * 10) - 5;

		Instantiate(paintSpotPreFab, new Vector3(4.99f, rightPositionY, rightPositionZ), Quaternion.Euler(getRandomRotation(), 0, 90));
	}
		
	void PaintBackWall() {
		float backPositionX = (Random.value * 10) - 5;
		float backPositionY = (Random.value * 10);

		Instantiate(paintSpotPreFab, new Vector3(backPositionX, backPositionY, -4.99f), Quaternion.Euler(getRandomRotation(), -90, -90));
	}

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.pitch = pitch;
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Left Hand") {
			audio.Play();
			GetComponent<Animation>().Play ();
			PaintWall (wall);
			PaintWall ("back");
		}

		if (other.gameObject.tag == "Right Hand") {
			audio.Play();
			GetComponent<Animation>().Play ();
			PaintWall (wall);
			PaintWall ("back");
		}
	}

	void PaintWall(string wall) {
		if (wall == "front") {
			PaintFrontWall ();
		} else if (wall == "back") {
			PaintBackWall ();
		} else if (wall == "left") {
			PaintLeftWall ();
		} else if (wall == "right") {
			PaintRightWall ();
		}
	}
}
