using UnityEngine;
using System.Collections;

public class AsteroidCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll);
        if (coll.gameObject.GetComponent<Health_Player>())
        {
            coll.gameObject.GetComponent<Health_Player>().Damage((int)Random.Range(10f, 80f));
            Debug.Log("damage");
        }
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
       
        if (coll.gameObject.GetComponent<Health>())
            coll.gameObject.GetComponent<Health>().Damage(200);
        else
        {
            Destroy(coll.gameObject);
        }
    }
}
