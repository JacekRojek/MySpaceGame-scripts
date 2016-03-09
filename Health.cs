using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {
    public float max_health=100f;
    public float health=100f;
    private Animator animator;
    private GameObject healtBar;
    public GameObject fuel;
    public GameObject metal;
    public Canvas canvas;
    void Start()
    {
        health = max_health;
        animator = gameObject.GetComponent<Animator>();
        healtBar = gameObject.transform.FindChild("HP_bar").gameObject;
        
    }
    public void Damage(int damage)
    {
        health -= damage;
        healtBar.transform.localScale = new Vector3(health / max_health, healtBar.transform.localScale.y, healtBar.transform.localScale.z);
            CheckHealth();
        
    }
    public void HP_UP(int hp)
    {
        health += hp;
    }
    void CheckHealth()
    {
        if (health <= 0)
        {
            canvas.enabled = false;
            animator.SetTrigger("IsDestroyedTrigger");
         
        }
    }

    public void Loot()
    {
        GameObject newfuel = Instantiate(fuel, transform.position, Quaternion.identity) as GameObject;
        newfuel.transform.position += new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        GameObject newmetal = Instantiate(metal, transform.position, Quaternion.identity) as GameObject;
        newmetal.transform.position += new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
    }

    void DestroyObject()
    {
            Destroy(gameObject);
    }
  
}
