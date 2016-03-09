using UnityEngine;
using System.Collections;

public class Bullet_enemie : MonoBehaviour {
    public int damage = 50;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Health_Player>())
        {
            coll.gameObject.GetComponent<Health_Player>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
