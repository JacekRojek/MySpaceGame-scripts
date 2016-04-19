using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Health_Player : MonoBehaviour {
    private static int health = 100;
    private Animator animator;
    private Text textBox;
    private GameObject panel;

    void Start()
    {
        textBox = this.transform.Find("/Canvas/TextHP").GetComponent<Text>();
        panel= this.transform.Find("/Canvas/GameOver_Panel").gameObject;
        panel.SetActive(false);
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
