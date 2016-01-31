using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {
	
	public float speed = 10.0F;
	public float reloadTime;


	private bool shotReady = true;
	private float xpos;
	private Rigidbody2D rig;
	private Vector3 mousePos;
	private Vector2 newPos;

	// Use this for initialization
	void Start () 
	{
		rig = gameObject.GetComponent<Rigidbody2D> ();
		xpos = transform.position.x;
	}

	// Update is called once per frame
	void Update ()
	{	
		
		// Get the position of the mouse. These are not world coordinates yet.
		mousePos	= Input.mousePosition;
		/* We want the the world coordinates 10 units in front of the camera,
		 * thus we set the z coordinate on the fixed value -10.
		 * Why -10? Our main camera has the z coordinate -10 and all our other
		 * stuff the z-coordinates 0.
		 */
		mousePos.z = 10;
		mousePos = Camera.main.ScreenToWorldPoint(mousePos);

		/* Now we move our spaceship with its rigidbody along the y-position of the mouse.
		 * Note: Don use transform, because it will ignore all colliders then.
		 */
		rig.MovePosition(new Vector2(xpos, mousePos.y));

		/* On left button mouseclick, calls the spawn() method of the spawner object,
		 * which is used to shoot a bullet.
		 */
		if (Input.GetMouseButton (0) & shotReady) {
			GetComponent<Spawner> ().spawn ();
			shotReady = false;
			StartCoroutine (Reload (reloadTime));
		}
	}

	// We use an IEnumerator to wait a specified amount of time between each shot.
	IEnumerator Reload(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		shotReady = true;
	}

	private void keepInBounds()
	{

	}
}
