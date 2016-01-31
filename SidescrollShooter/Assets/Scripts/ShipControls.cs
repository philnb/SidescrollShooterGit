using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {
	public float speed = 10.0F;
	bool shotReady = true;
	public float reloadTime;
	public float brake;
	public float sensitivity = 0.2F;
	private Rigidbody2D rig;
	Vector2 newPos;
	// Use this for initialization
	void Start () 
	{
		rig = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		float yMovement = Input.GetAxis ("Mouse Y");
		Debug.Log ("Y-Axis: " + yMovement);
		// Move the ship up if y-value > 0
		if (yMovement > sensitivity) {
			rig.velocity = Vector2.up * speed * Time.deltaTime;
		}

		// Move the ship down if y-value < 0
		else if (yMovement < -sensitivity) {
			rig.velocity = Vector2.down * speed * Time.deltaTime;
		} else {
			if (Mathf.Abs(rig.velocity.y) > 0.1) {
				if (rig.velocity.y < 0)
					rig.velocity += new Vector2 (0, brake);
				else
				    rig.velocity -= new Vector2 (0, brake);
			}
			else{
				rig.velocity = Vector2.zero;
				}


			if (Input.GetMouseButton (0) & shotReady) {
				GetComponent<Spawner> ().spawn ();
				shotReady = false;
				StartCoroutine (Reload (reloadTime));
			}
		}
	}

	IEnumerator Reload(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		shotReady = true;
	}
}
