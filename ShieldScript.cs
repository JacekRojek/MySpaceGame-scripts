﻿using UnityEngine;
using System.Collections;

public class ShieldScript : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
    }


}
