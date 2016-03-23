using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Planet_Enter : MonoBehaviour {
    private GameObject canvas;
    public GameObject panel;
	// Use this for initialization
	void Start () {
        canvas = transform.Find("/Canvas").gameObject;
        if (!canvas)
            Debug.Log(canvas);
	}
	void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject newPanel = Instantiate(panel, canvas.transform.position, Quaternion.identity) as GameObject;
            newPanel.transform.parent = canvas.transform;
            Time.timeScale = 0;
        }
    }
}
