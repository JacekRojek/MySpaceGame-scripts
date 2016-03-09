using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public int damage=50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Health>())
        {
            coll.gameObject.GetComponent<Health>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
