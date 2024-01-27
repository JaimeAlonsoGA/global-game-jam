using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionSize : MonoBehaviour
{
    public Transform Shepherd1;
    public Transform Shepherd2;
    //private Vector3 currentScreenSpace;

    public Vector3 PositionX { get; private set; }
    public Vector3 PositionY { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionX = new Vector3(Shepherd1.position.x, Shepherd1.position.y, -1);
        PositionY = new Vector3(Shepherd2.position.x, Shepherd2.position.y, -1);
        transform.position = Vector3.Lerp(PositionX , PositionY, 0.5f);

        //currentScreenSpace = new Vector3(Shepherd1.position.x, Shepherd1.position.y, 0);

    }
}
