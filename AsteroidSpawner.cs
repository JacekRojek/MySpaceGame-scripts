using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {
    public Transform asteroid;
    public Transform player;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3);

    }

    void SpawnEnemy()
    {


        // spawnPoint.x += Random.Range(-10f, 10f);
        Vector3 spawnPoint = player.TransformPoint(Vector3.up * 10);
        spawnPoint.x += Random.Range(-5, 5);
        spawnPoint.y += Random.Range(-3, 3);

        //instantiate new Asteroid in random location front of a player.
        GameObject newAsteroid = Instantiate(asteroid.gameObject, spawnPoint, Quaternion.identity) as GameObject;
        newAsteroid.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100f, 100f), Random.Range(-100f, 100f)), ForceMode2D.Impulse);
        newAsteroid.transform.parent = transform;
        newAsteroid.transform.localScale=new Vector3(Random.Range(1f, 3f),Random.Range(1f, 3f), 0);
    }
}
