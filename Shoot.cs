using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject bullet;
    public float bulletsPerSecond=1f;
    private Transform player;
    private Rigidbody2D rb;
    public int speed=200;
    public float bulletSpeed=10f;
    
    void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<Transform>();
        InvokeRepeating("ShootBullet", 1, 5.0f / bulletsPerSecond);
        InvokeRepeating("Move", 1, 2f);
    }
	
    void Move()
    {
        Vector3 forceVector = new Vector3(Random.Range(-speed, speed), Random.Range(-speed, speed), 0);
        rb.AddForce(forceVector/1000f , ForceMode2D.Impulse);
    }
	// Update is called once per frame
	void Update () {
        Vector3 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
    }
    void ShootBullet()
    {
        GameObject go = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        go.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletSpeed);
    }
}
