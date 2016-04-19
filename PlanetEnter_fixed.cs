using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlanetEnter_fixed : MonoBehaviour
{
    private GameObject canvas;
    public GameObject panel;
    void Start()
    {
        canvas = transform.Find("/Canvas").gameObject;
        if (!canvas)
            Debug.Log(canvas);
        //randomLevel = Random.Range(0, events.Length);
    }
    void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject newPanel = Instantiate(panel, canvas.transform.position, Quaternion.identity) as GameObject;
            newPanel.transform.parent = canvas.transform;
            newPanel.transform.GetChild(0).FindChild("Main_text").GetComponent<PanelPlanet>().planetName = this.GetComponent<SpriteRenderer>().sprite.name;
            Time.timeScale = 0;

        }
    }
}

