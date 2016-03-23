using UnityEngine;
using System.Collections;

public class BlaskHole : MonoBehaviour {
    private LevelManager levelManager;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
	void OnTriggerEnter2D(Collider2D col)
    {
        if (!(col.gameObject.name == "Player"))
        {
            Destroy(col.gameObject);
        }
        else
        {
            Debug.Log("PLayer entered Black Hole");
            levelManager.GetComponent<LevelManager>().LoadLevel("Area1");
;        }
    }
}
