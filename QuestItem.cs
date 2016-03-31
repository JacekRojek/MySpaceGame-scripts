using UnityEngine;
using System.Collections;

public class QuestItem : MonoBehaviour {


    void Start()
    {
       
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.GetComponent<controll>())
        {
            Planet1_1_Text.itemPicked = true;
            Destroy(gameObject);
        }

    }
}
