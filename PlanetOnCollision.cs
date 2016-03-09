using UnityEngine;
using System.Collections;

public class PlanetOnCollision : MonoBehaviour {
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            levelManager.LoadLevel("Base");
        }
    }
}
