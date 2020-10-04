﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    public float SmoothSpeed = 0.125f;

    void Update()
    {
        transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y, transform.position.z);  
    }
}
