using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Health_Player : MonoBehaviour {
    public int health = 100;
    private Animator animator;
    public Text textBox;
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
        animator = gameObject.GetComponent<Animator>();
     
            textBox.text = "HP   " + health.ToString();
    }
    public void Damage(int damage)
    {
        health -= damage;
     
        textBox.text = "HP   " + health.ToString();
        if (health <= 0)
        {
            panel.SetActive(true);
            animator.SetTrigger("IsDestroyedTrigger");

        }


    }
    public void HP_UP(int hp)
    {
        health += hp;
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

}
