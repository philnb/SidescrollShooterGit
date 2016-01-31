using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (Vector2.left *speed *Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
