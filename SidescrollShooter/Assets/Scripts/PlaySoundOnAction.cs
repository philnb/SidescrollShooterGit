using UnityEngine;
using System.Collections;

public class PlaySoundOnAction : MonoBehaviour {

	public bool onDestroy 	= false;
	public bool onKeyStroke = false;
	public KeyCode keySound;

	// Use this for initialization
	void Start () 
	{
		GetComponent<AudioSource>().Stop();
	}

	// Update is called once per frame
	void Update () 
	{
		if(onDestroy && gameObject == null)
		{
			gameObject.GetComponent<AudioSource>().Play();
		}

		if(onKeyStroke)
		{
			if(Input.GetKey(keySound))
				gameObject.GetComponent<AudioSource>().Play();
		}
	
	}

}
