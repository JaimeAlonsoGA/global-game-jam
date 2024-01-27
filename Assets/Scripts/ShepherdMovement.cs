using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShepherdMovement : MonoBehaviour
{
    public GameObject shepherd1;
    public GameObject shepherd2;

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
            if ((Mathf.Abs(shepherd2.transform.position.y - shepherd1.transform.position.y) < 20f || shepherd1.transform.position.y < shepherd2.transform.position.y) && (y > 0 || Input.GetKey(KeyCode.W)))
            {
                gameObject.transform.position += new Vector3(0, 2.5f, 0) * Time.deltaTime;
            }
            if ((Mathf.Abs(shepherd2.transform.position.x - shepherd1.transform.position.x) < 35f || shepherd1.transform.position.x < shepherd2.transform.position.x) && (x > 0 || Input.GetKey(KeyCode.D)))
            {
                gameObject.transform.position += new Vector3(2.5f, 0, 0) * Time.deltaTime;
            }
            if ((Mathf.Abs(shepherd2.transform.position.x - shepherd1.transform.position.x) < 35f  || shepherd1.transform.position.x > shepherd2.transform.position.x) && (x < 0 || Input.GetKey(KeyCode.A)))
            {
                gameObject.transform.position += new Vector3(-2.5f, 0, 0) * Time.deltaTime;
            }
            if ((Mathf.Abs(shepherd2.transform.position.y - shepherd1.transform.position.y) < 20f  || shepherd1.transform.position.y > shepherd2.transform.position.y) && (y < 0 || Input.GetKey(KeyCode.S)))
            {
                gameObject.transform.position += new Vector3(0, -2.5f, 0) * Time.deltaTime;
            }
        }
        else if (gameObject.CompareTag("Shepherd2"))
        {
            if ((Mathf.Abs(shepherd1.transform.position.y - shepherd2.transform.position.y) < 20f || shepherd2.transform.position.y < shepherd1.transform.position.y) && (yTwo > 0 || Input.GetKey(KeyCode.UpArrow)))
                gameObject.transform.position += new Vector3(0, 2.5f, 0) * Time.deltaTime;
            if ((Mathf.Abs(shepherd1.transform.position.x - shepherd2.transform.position.x) < 35f || shepherd2.transform.position.x < shepherd1.transform.position.x) && (xTwo > 0 || Input.GetKey(KeyCode.RightArrow)))
                gameObject.transform.position += new Vector3(2.5f, 0, 0) * Time.deltaTime;
            if ((Mathf.Abs(shepherd1.transform.position.x - shepherd2.transform.position.x) < 35f || shepherd2.transform.position.x > shepherd1.transform.position.x) && (xTwo < 0 || Input.GetKey(KeyCode.LeftArrow)))
                gameObject.transform.position += new Vector3(-2.5f, 0, 0) * Time.deltaTime;
            if ((Mathf.Abs(shepherd1.transform.position.y - shepherd2.transform.position.y) < 20f || shepherd2.transform.position.y > shepherd1.transform.position.y) && (yTwo < 0 || Input.GetKey(KeyCode.DownArrow)))
                gameObject.transform.position += new Vector3(0, -2.5f, 0) * Time.deltaTime;
        }
    }
}
