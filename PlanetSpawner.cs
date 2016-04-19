using UnityEngine;
using System.Collections;

public class PlanetSpawner : MonoBehaviour {
    public Sprite[] spriteRenderArray;
    public GameObject planet;
    public Sprite planet_LouisV;
    public GameObject blackHole;
    public int numberOfBH=5;
	// Use this for initialization
	void Awake () {
        SpawnBlackHole();
        spawnPlanet();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    // instantiate planets at random locations for all avalible sprites. 
    void spawnPlanet()
    {
        GameObject LouisV= Instantiate(planet, new Vector2(10f, 10f), Quaternion.identity)as GameObject;
        LouisV.GetComponent<SpriteRenderer>().sprite = planet_LouisV;
        for(int a=0; a < spriteRenderArray.Length; a++)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-120, 120), Random.Range(-90, 90), 0);
            GameObject newPlanet = Instantiate(planet, spawnPoint, Quaternion.identity) as GameObject;
            newPlanet.GetComponent<SpriteRenderer>().sprite = spriteRenderArray[a]; 
            float randomScale = Random.Range(0.8f, 1.2f);
            newPlanet.GetComponent<Transform>().localScale = new Vector3(randomScale, randomScale, 1);
            newPlanet.transform.parent = transform;
        }
    }
    void SpawnBlackHole()
    {
        for (int i = 0; i <= numberOfBH; i++) {
           
            Vector3 spawnPoint = new Vector3(Random.Range(-120, 120), Random.Range(-90, 90), 0);
            GameObject newBlackHole = Instantiate(blackHole, spawnPoint, Quaternion.identity) as GameObject;
            float randomScale = Random.Range(0.8f, 1.2f);
            newBlackHole.GetComponent<Transform>().localScale = new Vector3(randomScale, randomScale, 1);
            newBlackHole.transform.parent = transform;
        }
    }
}
