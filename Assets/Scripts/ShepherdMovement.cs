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
        float x = Input.GetAxis("HorizontalOne");
        float y = Input.GetAxis("VerticalOne");

        float xTwo = Input.GetAxis("HorizontalTwo");
        float yTwo = Input.GetAxis("VerticalTwo");

        //Movement for controller
        if (gameObject.CompareTag("Shepherd"))
        {
            if (y > 0 || Input.GetKey(KeyCode.W))
                gameObject.transform.position += new Vector3(0, 2.5f, 0) * Time.deltaTime;
            if (x > 0 || Input.GetKey(KeyCode.D))
                gameObject.transform.position += new Vector3(2.5f, 0, 0) * Time.deltaTime;
            if (x < 0 || Input.GetKey(KeyCode.A))
                gameObject.transform.position += new Vector3(-2.5f, 0, 0) * Time.deltaTime;
            if (y < 0 || Input.GetKey(KeyCode.S))
                gameObject.transform.position += new Vector3(0, -2.5f, 0) * Time.deltaTime;
        }
        else if (gameObject.CompareTag("Shepherd2"))
        {
            if (yTwo > 0 || Input.GetKey(KeyCode.UpArrow))
                gameObject.transform.position += new Vector3(0, 2.5f, 0) * Time.deltaTime;
            if (xTwo > 0 || Input.GetKey(KeyCode.RightArrow))
                gameObject.transform.position += new Vector3(2.5f, 0, 0) * Time.deltaTime;
            if (xTwo < 0 || Input.GetKey(KeyCode.LeftArrow))
                gameObject.transform.position += new Vector3(-2.5f, 0, 0) * Time.deltaTime;
            if (yTwo < 0 || Input.GetKey(KeyCode.DownArrow))
                gameObject.transform.position += new Vector3(0, -2.5f, 0) * Time.deltaTime;
        }
    }
}
