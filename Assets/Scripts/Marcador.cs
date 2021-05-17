using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcador : MonoBehaviour {

    private const float MAX_SPEED_ANGLE = 15;
    private const float ZERO_SPEED_ANGLE = 154;

    private Transform needleTransform;

    private float speedMax;
    private float speed;

    private void Awake()
    {
        needleTransform = transform.Find("needle");

        speed = 0f;
        speedMax = 200f;
    }
 
    private void Update() {
        HandlePlayerInput();
        
        //speed += 30f * Time.deltaTime;
        if (speed > speedMax) speed = speedMax;
        
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
        
    }

    private void HandlePlayerInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float acceleration = 100f;
            speed += acceleration * Time.deltaTime;
        }
        else
        {
            float deceleration = 60f;
            speed -= deceleration * Time.deltaTime;
        }
    }

    private float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}
