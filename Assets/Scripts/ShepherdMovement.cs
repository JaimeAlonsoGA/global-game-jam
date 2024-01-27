using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShepherdMovement : MonoBehaviour
{
    public Sprite walkUp1;
    public Sprite walkUp2;
    public Sprite walkDown1;
    public Sprite walkDown2;
    public Sprite walkSide1;
    public Sprite walkSide2;

    public Sprite idleUp1;
    public Sprite idleUp2;
    public Sprite idleDown1;
    public Sprite idleDown2;
    public Sprite idleSide1;
    public Sprite idleSide2;

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
            {
                gameObject.transform.position += new Vector3(0f, 2.5f, 0) * Time.deltaTime;
                gameObject.GetComponent<SpriteRenderer>().sprite = walkUp1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.position += new Vector3(2.5f, 0f, 0) * Time.deltaTime;
                gameObject.GetComponent<SpriteRenderer>().sprite = walkSide1;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.position += new Vector3(-2.5f, 0f, 0) * Time.deltaTime;
                gameObject.GetComponent<SpriteRenderer>().sprite = walkSide1;
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.transform.position += new Vector3(0f, -2.5f, 0) * Time.deltaTime;
                gameObject.GetComponent<SpriteRenderer>().sprite = walkDown1;
            }
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
