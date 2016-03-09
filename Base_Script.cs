using UnityEngine;
using System.Collections;

public class Base_Script : MonoBehaviour {
    private Transform text;
    public LevelManager levelManager;
    void Start()
    {
        text = gameObject.transform.GetChild(0);
        text.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

	void OnTriggerEnter2D()
    {
        text.gameObject.GetComponent<MeshRenderer>().enabled = true;
      
    }
    void OnTriggerExit2D()
    {
        text.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            levelManager.LoadLevel("Base");
        }
    }
    }
