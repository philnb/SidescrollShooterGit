using UnityEngine;
using System.Collections;

public class EnemyShipMovement : MonoBehaviour {
	public bool Up = true;
	public float deltaRange = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.tag);
		if (other.tag == "RightPanel") {
			if (Up)
				gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,deltaRange));
			else
				gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-deltaRange));
		}
	}
}
