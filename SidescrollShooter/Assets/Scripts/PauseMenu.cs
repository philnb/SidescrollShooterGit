using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
    private bool paused = false;
	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            Time.timeScale = 0;
            GetComponent<ShipControls>().setShotReady(false);
            paused = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused)
        {
            Time.timeScale = 1;
            GetComponent<ShipControls>().setShotReady(true);
            paused = false;
        }
	}

    void OnGUI()
    {
        if(paused)
        {
            GUI.Label(new Rect (Screen.width/2, Screen.height/2, 1000, 1000) , "Pause");
        }
    }
}
