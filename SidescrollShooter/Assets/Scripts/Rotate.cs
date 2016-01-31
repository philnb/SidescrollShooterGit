using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D> ().AddTorque (speed *Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
