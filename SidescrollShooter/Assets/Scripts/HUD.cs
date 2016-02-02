using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour
{
    int score;
	// Use this for initialization
	void Start ()
    {
        score = 44;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Score: " + score);
    }
}
