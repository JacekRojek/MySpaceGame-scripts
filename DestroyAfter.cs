﻿using UnityEngine;
using System.Collections;

public class DestroyAfter : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Destroy(this.gameObject, 2f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
