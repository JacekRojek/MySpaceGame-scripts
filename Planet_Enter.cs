using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Planet_Enter : MonoBehaviour {
    private GameObject canvas;
    //public GameObject panel;
    public GameObject[] events;
    private int randomLevel=2;
    // Use this for initialization
    void Start () {
        canvas = transform.Find("/Canvas").gameObject;
        if (!canvas)
            Debug.Log(canvas);
        //randomLevel = Random.Range(0, events.Length);
    }
	void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            

            GameObject newPanel = Instantiate(events[randomLevel], canvas.transform.position, Quaternion.identity) as GameObject;
            newPanel.transform.parent = canvas.transform;
            Time.timeScale = 0;
        }
    }
}
