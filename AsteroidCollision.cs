using UnityEngine;
using System.Collections;

public class AsteroidCollision : MonoBehaviour {
    int HP;
    
    void Start()
    {
        HP = (int)Random.Range(70f, 150f);


    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<Health_Player>())
        {
            CheckState();
            coll.gameObject.GetComponent<Health_Player>().Damage((int)Random.Range(10f, 80f));
            HP -= (int)Random.Range(10f, 80f);

           
        }
        if (coll.gameObject.GetComponent<Health>())
        {
            CheckState();
            coll.gameObject.GetComponent<Health>().Damage((int)Random.Range(10f, 20f));
            HP -= (int)Random.Range(10f, 80f);
            
           
        }
 
        }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Bullet>())
        {
            CheckState();
      
            HP = HP - coll.gameObject.GetComponent<Bullet>().damage;

            Destroy(coll.gameObject);
           
        }
        if (coll.gameObject.GetComponent<Bullet_enemie>())
        {
            CheckState();

            HP = HP - coll.gameObject.GetComponent<Bullet_enemie>().damage;

            Destroy(coll.gameObject);
            
        }
    }
    void CheckState()
    {
       
        if (HP <= 50)
        {
            this.GetComponent<SpriteRenderer>().color = Color.gray;
            
        }
        if (HP <= 0)
        {
            this.GetComponent<Animator>().SetTrigger("Destroyed");
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
