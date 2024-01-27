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
        float x = Input.GetAxis("HorizontalOne");
        float y = Input.GetAxis("VerticalOne");

        float xTwo = Input.GetAxis("HorizontalTwo");
        float yTwo = Input.GetAxis("VerticalTwo");

        //Movement for controller
        if (gameObject.CompareTag("Shepherd"))
        {
            if (y > 0 || Input.GetKey(KeyCode.W))
            {
                gameObject.transform.position += new Vector3(0, 2.5f, 0) * Time.deltaTime;
                // gameObject.GetComponent<SpriteRenderer>().sprite = walkUp1;
            }
            if (x > 0 || Input.GetKey(KeyCode.D))
            {
                gameObject.transform.position += new Vector3(2.5f, 0, 0) * Time.deltaTime;
                // gameObject.GetComponent<SpriteRenderer>().sprite = walkSide1;
                // gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (x < 0 || Input.GetKey(KeyCode.A))
            {
                gameObject.transform.position += new Vector3(-2.5f, 0, 0) * Time.deltaTime;
                // gameObject.GetComponent<SpriteRenderer>().sprite = walkSide1;
                // gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (y < 0 || Input.GetKey(KeyCode.S))
            {
                gameObject.transform.position += new Vector3(0, -2.5f, 0) * Time.deltaTime;
                // gameObject.GetComponent<SpriteRenderer>().sprite = walkDown1;
            }
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
