using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour {

	public float velocity = 10f;
	public float rotate_velocity = 80f;
	public GameObject camera = null;
	public GameObject breathBubblesParticles = null;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (camera != null) {
			camera.transform.position = new Vector3(transform.position.x + 18, transform.position.y, camera.transform.position.z);
		}

		if (breathBubblesParticles != null) {
			breathBubblesParticles.transform.position = new Vector3(transform.position.x, transform.position.y, breathBubblesParticles.transform.position.z);
		}

		Vector3 angle = Vector3.zero;

		if (Input.GetKey (KeyCode.LeftArrow) ) {
			angle = Vector3.forward * rotate_velocity * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			angle = Vector3.forward * -rotate_velocity * Time.deltaTime;
		}

		transform.Rotate (angle);
		transform.Translate (Vector3.right * velocity * Time.deltaTime);
	}
}
