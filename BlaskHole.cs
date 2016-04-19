using UnityEngine;
using System.Collections;

public class BlaskHole : MonoBehaviour
{
    private LevelManager levelManager;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        int randomLocation = Random.Range(0, 2);
        if (!(col.gameObject.name == "Player"))
        {
            Destroy(col.gameObject);
        }
        else
        {
            if (Application.loadedLevel == 1)
            {

                if (randomLocation >= 1)
                    levelManager.GetComponent<LevelManager>().LoadLevel("Area2");
                else if (randomLocation < 1)
                    levelManager.GetComponent<LevelManager>().LoadLevel("Area1");
            }
            if (Application.loadedLevel != 1)
            {
                levelManager.GetComponent<LevelManager>().LoadLevel("Game");
            }

        }
    }
}
