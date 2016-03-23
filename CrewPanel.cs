using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrewPanel : MonoBehaviour {
    public Sprite[] sprites_champions;
    public GameObject eq_element;
	// Use this for initialization
	void Start () {
        for (int a = 0; a < sprites_champions.Length; a++)
        {
            eq_element.GetComponent<Image>().sprite = sprites_champions[a];
            GameObject newChampion = Instantiate(eq_element, Vector3.zero, Quaternion.identity) as GameObject;
          
            newChampion.transform.parent = this.transform;
        }

        }

}
