using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public Vector2 offset = Vector2.zero;
	public GameObject spawnObject;

	public void spawn()
    {
		Instantiate (spawnObject,  new Vector2(transform.position.x,transform.position.y) + offset, Quaternion.identity);
	}
}
