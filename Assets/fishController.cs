using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour {

	public float velocity = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position.Set(transform.position.x + velocity, transform.position.y, transform.position.z);
	}
}
