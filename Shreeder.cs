using UnityEngine;
using System.Collections;

public class Shreeder : MonoBehaviour {

void OnTriggerExit2D(Collider2D coll)
    {

        Destroy(coll.gameObject);
    }
}
