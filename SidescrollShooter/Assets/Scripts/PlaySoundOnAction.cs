using UnityEngine;
using System.Collections;

public class PlaySoundOnAction : MonoBehaviour {

	public bool onDestroy 	= false;
	public bool onKeyStroke = false;
	public KeyCode key;

	// Use this for initialization
	void Start () 
	{
		// This because audioclip immediately launched at start.
		GetComponent<AudioSource>().Stop();
	}

	// Update is called once per frame
	void Update () 
	{
		/**
		 * TODO: Does not work yet.
		 * Should play a sound when a gameobject is destroyed.
		 **/
		if(onDestroy && gameObject == null)
		{
			gameObject.GetComponent<AudioSource>().Play();
		}

		/**
		 * By pressing a key (specified in variable: key), plays the AudioSource
		 * that is attached to the same object this script is attached.
		 **/
		if(onKeyStroke)
		{
			if(Input.GetKey(key))
				gameObject.GetComponent<AudioSource>().Play();
		}
	
	}

}
