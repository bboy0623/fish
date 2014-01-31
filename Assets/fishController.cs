using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour {

	public float velocity = 10f;
	public float rotate_velocity = 30f;
	public GameObject camera = null;
	public GameObject breathBubblesParticles = null;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 angle = Vector3.zero;

		bool canRotateCounterClockwise = transform.rotation.z < 0.6;

		if (Input.GetKey (KeyCode.LeftArrow) && canRotateCounterClockwise) {
			angle += Vector3.forward * rotate_velocity * Time.deltaTime;
		}

		bool canRotateClockwise = transform.rotation.z > -0.6;

		if (Input.GetKey (KeyCode.RightArrow) && canRotateClockwise) {
			angle -= Vector3.forward * rotate_velocity * Time.deltaTime;
		}

		transform.Rotate (angle);
		transform.Translate (Vector3.right * velocity * Time.deltaTime);

		print (transform.localRotation);

		if (camera != null) {
			camera.transform.position = new Vector3(transform.position.x + 16, transform.position.y, camera.transform.position.z);
		}
		
		if (breathBubblesParticles != null) {
			breathBubblesParticles.transform.position = new Vector3(transform.position.x, transform.position.y, breathBubblesParticles.transform.position.z);
		}
	}
}
