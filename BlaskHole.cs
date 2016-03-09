using UnityEngine;
using System.Collections;

public class BlaskHole : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
    {
        if (!(col.gameObject.name == "Player"))
        {
            Destroy(col.gameObject);
        }
        else
        {
            Debug.Log("PLayer entered Black Hole");

;        }
    }
}
