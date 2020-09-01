﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * 0.035f;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * 0.035f;
        }
    }
}
