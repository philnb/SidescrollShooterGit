using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
	public bool selfDamage = true;
	public string targetTag = "Player";

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == targetTag) {
			other.GetComponent<Health> ().damage (1);
			if (selfDamage) {
				gameObject.GetComponent<Health> ().damage (1);
			}

		}
	}
}
