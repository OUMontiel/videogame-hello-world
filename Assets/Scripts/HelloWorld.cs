﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
	public GameObject prefabCube;
	
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloWorld");

        GameObject.Instantiate(prefabCube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
