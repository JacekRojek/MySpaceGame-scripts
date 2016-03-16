using UnityEngine;
using System.Collections;


public class controll : MonoBehaviour {
    public float RotateSpeed = 3.0f;
    public float MoveSpeed = 3000.0f;
    public float BulletSpeed = 3.0f;
    private Animator animator;
    private Rigidbody2D rb;
    private ForceMode mode;
    public GameObject bullet;
    private Transform gun;
    private GameObject shield;





    void Start () {
      rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        gun = gameObject.transform.GetChild(0);
        shield = this.gameObject.transform.FindChild("Shield").gameObject ;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(-Vector3.back * RotateSpeed * Time.deltaTime);

            animator.SetTrigger("IsMovingTrigger");
        }

        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("IsMovingTrigger");
           
        rb.AddForce(transform.up * MoveSpeed * Time.deltaTime, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetTrigger("IsMovingTrigger");
           
           rb.AddForce(transform.up * 0.5f * MoveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("IsMovingTrigger");
           
         rb.AddForce(transform.up * -2 * MoveSpeed * Time.deltaTime, ForceMode2D.Force);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("IsMovingTrigger");
            this.transform.Rotate(Vector3.back * RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            shield.SetActive(true);
            StartCoroutine(Delete());
        }

       
    }
    IEnumerator Delete()
    {
        yield return new WaitForSeconds(5);    //Wait 5s

        shield.SetActive(false);
    }

    void Shoot()
    {
            GameObject bulletIns= Instantiate(bullet,gun.position, gun.rotation) as GameObject;
            bulletIns.GetComponent<Rigidbody2D>().AddForce(transform.up *  BulletSpeed , ForceMode2D.Force); 
    }

    void FixedUpdate ()
    {
           // float moveHorizontal = Input.GetAxis("Horizontal");
           // float moveVertical = Input.GetAxis("Vertical");

           // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        }
    }


