using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShepherdMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Shepherd"))
        {
            if (Input.GetKey(KeyCode.W))
                gameObject.transform.position += new Vector3(0f, 2.5f, 0) * Time.deltaTime;
            if (Input.GetKey(KeyCode.D))
                gameObject.transform.position += new Vector3(2.5f, 0f, 0) * Time.deltaTime;
            if (Input.GetKey(KeyCode.A))
                gameObject.transform.position += new Vector3(-2.5f, 0f, 0) * Time.deltaTime;
            if (Input.GetKey(KeyCode.S))
                gameObject.transform.position += new Vector3(0f, -2.5f, 0) * Time.deltaTime;
        }
        else if (gameObject.CompareTag("Shepherd2"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
                gameObject.transform.position += new Vector3(0f, 2.5f, 0) * Time.deltaTime;
            if (Input.GetKey(KeyCode.RightArrow))
                gameObject.transform.position += new Vector3(2.5f, 0f, 0) * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
                gameObject.transform.position += new Vector3(-2.5f, 0f, 0) * Time.deltaTime;
            if (Input.GetKey(KeyCode.DownArrow))
                gameObject.transform.position += new Vector3(0f, -2.5f, 0) * Time.deltaTime;
        }

    }
}
