using UnityEngine;
using System.Collections;

public class EnemiesSpawner : MonoBehaviour {
    public Transform[] enemy;
    public Transform player;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 1, 3);

	}
	
void SpawnEnemy()
    {

        int random = Random.Range(0, enemy.Length);
        // spawnPoint.x += Random.Range(-10f, 10f);
        Vector3 spawnPoint = player.TransformPoint(Vector3.up * 10);
       spawnPoint.x += Random.Range(-5, 5);
        spawnPoint.y += Random.Range(-3, 3);

        GameObject newEnemy= Instantiate(enemy[random].gameObject, spawnPoint, Quaternion.identity)as GameObject;
        
        newEnemy.transform.parent = transform;

    }
}
