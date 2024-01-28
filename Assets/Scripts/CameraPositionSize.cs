using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraPositionSize : MonoBehaviour
{
    float levelMinX = -1.85f;
    float levelMaxX = 1.85f;
    float levelMinY = -1f;
    float levelMaxY = 1f;

    public Transform Shepherd1;
    public Transform Shepherd2;
    //private Vector3 currentScreenSpace;

    public Vector3 PositionX { get; private set; }
    public Vector3 PositionY { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        PositionX = new Vector3(Shepherd1.position.x, Shepherd1.position.y, -1);
        PositionY = new Vector3(Shepherd2.position.x, Shepherd2.position.y, -1);

        transform.position = Vector3.Lerp(PositionX, PositionY, 0.5f);
        float x = Mathf.Clamp(transform.position.x, levelMinX, levelMaxX);
        float y = Mathf.Clamp(transform.position.y, levelMinY, levelMaxY);
        transform.position = new Vector3 (x, y);
    }
}
