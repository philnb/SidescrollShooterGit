using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {


	public int maxHealth = 1;
	int currentHealth;
	public bool deathAnimation = false;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}

	public void heal(int value){
		currentHealth += value;
		if (currentHealth > maxHealth) {
			currentHealth = maxHealth;
		}

	}

	public void upgradeHealth(int value){
		maxHealth += value;
	}

	public void downgradeHealth(int value){
		maxHealth -= value;
	}

	public void damage(int value){
		currentHealth -= value;
		Debug.Log (gameObject.name + " " + currentHealth);
		if (currentHealth <= 0) {
			currentHealth = 0;
			if (deathAnimation) {

			} else {
				Destroy (gameObject);
			}
		}
	}
}
