using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionSize : MonoBehaviour
{
    public Transform Shepherd1;
    public Transform Shepherd2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(new Vector3(Shepherd1.position.x, Shepherd1.position.y, -12) , new Vector3(Shepherd2.position.x, Shepherd2.position.y, -12), 0.5f);
    }
}
