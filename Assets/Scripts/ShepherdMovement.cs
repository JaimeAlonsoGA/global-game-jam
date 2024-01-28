using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShepherdMovement : MonoBehaviour
{
    public GameObject shepherd1;
    public GameObject shepherd2;
    public Doors doors;

    Animator animator1;
    SpriteRenderer spriteRenderer1;
    Animator animator2;
    SpriteRenderer spriteRenderer2;

    // Start is called before the first frame update
    void Start()
    {
        animator1 = shepherd1.GetComponent<Animator>();
        spriteRenderer1 = shepherd1.GetComponent<SpriteRenderer>();
        animator2 = shepherd2.GetComponent<Animator>();
        spriteRenderer2 = shepherd2.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doors.doorClosed == true)
        {
            shepherd1.transform.position = shepherd1.transform.position;
            shepherd2.transform.position = shepherd2.transform.position;
        }
        else
        {
            float x = Input.GetAxis("HorizontalOne");
            float y = Input.GetAxis("VerticalOne");

            float xTwo = Input.GetAxis("HorizontalTwo");
            float yTwo = Input.GetAxis("VerticalTwo");

            Vector3 firstPosition = gameObject.transform.position;
            if (gameObject.CompareTag("Shepherd"))
            {
                spriteRenderer1.sortingOrder = 1000 - Mathf.RoundToInt(transform.position.y * 100);
                if ((Mathf.Abs(shepherd2.transform.position.y - shepherd1.transform.position.y) < 7f || shepherd1.transform.position.y < shepherd2.transform.position.y) && (y > 0 || Input.GetKey(KeyCode.W)))
                    gameObject.transform.position += new Vector3(0, 4f, 0) * Time.deltaTime;
                if ((Mathf.Abs(shepherd2.transform.position.x - shepherd1.transform.position.x) < 13f || shepherd1.transform.position.x < shepherd2.transform.position.x) && (x > 0 || Input.GetKey(KeyCode.D)))
                    gameObject.transform.position += new Vector3(4f, 0, 0) * Time.deltaTime;
                if ((Mathf.Abs(shepherd2.transform.position.x - shepherd1.transform.position.x) < 13f || shepherd1.transform.position.x > shepherd2.transform.position.x) && (x < 0 || Input.GetKey(KeyCode.A)))
                    gameObject.transform.position += new Vector3(-4f, 0, 0) * Time.deltaTime;
                if ((Mathf.Abs(shepherd2.transform.position.y - shepherd1.transform.position.y) < 7f || shepherd1.transform.position.y > shepherd2.transform.position.y) && (y < 0 || Input.GetKey(KeyCode.S)))
                    gameObject.transform.position += new Vector3(0, -4f, 0) * Time.deltaTime;

                Vector3 direction = Vector3.Normalize(gameObject.transform.position - firstPosition);
                if (direction.x > 0.5f)
                {
                    animator1.Play("WalkSide1");
                    spriteRenderer1.flipX = false;
                }
                else if (direction.x < -0.5f)
                {
                    animator1.Play("WalkSide1");
                    spriteRenderer1.flipX = true;
                }
                else if (direction.y > 0.5f)
                {
                    animator1.Play("WalkUp1");
                }
                else if (direction.y < -0.5f)
                {
                    animator1.Play("WalkDown1");
                }
                else
                {
                    animator1.Play("Idle1");
                }
            }
            else if (gameObject.CompareTag("Shepherd2"))
            {
                spriteRenderer2.sortingOrder = 1000 - Mathf.RoundToInt(transform.position.y * 100);
                if ((Mathf.Abs(shepherd1.transform.position.y - shepherd2.transform.position.y) < 7f || shepherd2.transform.position.y < shepherd1.transform.position.y) && (yTwo > 0 || Input.GetKey(KeyCode.UpArrow)))
                    gameObject.transform.position += new Vector3(0, 4f, 0) * Time.deltaTime;
                if ((Mathf.Abs(shepherd1.transform.position.x - shepherd2.transform.position.x) < 13f || shepherd2.transform.position.x < shepherd1.transform.position.x) && (xTwo > 0 || Input.GetKey(KeyCode.RightArrow)))
                    gameObject.transform.position += new Vector3(4f, 0, 0) * Time.deltaTime;
                if ((Mathf.Abs(shepherd1.transform.position.x - shepherd2.transform.position.x) < 13f || shepherd2.transform.position.x > shepherd1.transform.position.x) && (xTwo < 0 || Input.GetKey(KeyCode.LeftArrow)))
                    gameObject.transform.position += new Vector3(-4f, 0, 0) * Time.deltaTime;
                if ((Mathf.Abs(shepherd1.transform.position.y - shepherd2.transform.position.y) < 7f || shepherd2.transform.position.y > shepherd1.transform.position.y) && (yTwo < 0 || Input.GetKey(KeyCode.DownArrow)))
                    gameObject.transform.position += new Vector3(0, -4f, 0) * Time.deltaTime;

                Vector3 direction = Vector3.Normalize(gameObject.transform.position - firstPosition);
                if (direction.x > 0.5f)
                {
                    animator2.Play("WalkSide2");
                    spriteRenderer2.flipX = false;
                }
                else if (direction.x < -0.5f)
                {
                    animator2.Play("WalkSide2");
                    spriteRenderer2.flipX = true;
                }
                else if (direction.y > 0.5f)
                {
                    animator2.Play("WalkUp2");
                }
                else if (direction.y < -0.5f)
                {
                    animator2.Play("WalkDown2");
                }
                else
                {
                    animator2.Play("Idle2");
                }
            }
        }
    }
}
