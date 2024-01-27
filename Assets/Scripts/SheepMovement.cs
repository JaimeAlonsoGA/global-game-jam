using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour
{
    public GameObject[] shepherds;
    float timeToNextAction;
    float currentTimeToNextAction;
    Vector3 nextPosition;
    Vector3 scapePosition;
    float speed = 0.05f;
    Animator animator;
    SpriteRenderer spriteRenderer;
    // private FMOD.Studio.EventInstance sheepInstace;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        // sheepInstace = FMODUnity.RuntimeManager.CreateInstance("event:/Sheep");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        spriteRenderer.sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;
        currentTimeToNextAction += Time.deltaTime;
        if (currentTimeToNextAction >= timeToNextAction)
        {
            timeToNextAction = Random.Range(5f, 10f);
            currentTimeToNextAction = 0f;
            nextPosition = transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        }

        scapePosition = Vector3.zero;
        if (Vector3.Distance(shepherds[0].transform.position, transform.position) < 3f)
        {
            scapePosition += transform.position + Vector3.Normalize(transform.position - shepherds[0].transform.position);
        }
        if (Vector3.Distance(shepherds[1].transform.position, transform.position) < 3f)
        {
            scapePosition += transform.position + Vector3.Normalize(transform.position - shepherds[1].transform.position);
        }
        if (scapePosition != Vector3.zero)
            nextPosition = scapePosition;

        if (transform.position == nextPosition)
            animator.Play("Idle");
        else
        {
            Vector3 direction = Vector3.Normalize(nextPosition - transform.position);

            if (direction.x > 0.5f)
            {
                animator.Play("WalkSide");
                spriteRenderer.flipX = false;
            }
            else if (direction.x < -0.5f)
            {
                animator.Play("WalkSide");
                spriteRenderer.flipX = true;
            }
            else if (direction.y > 0.5f)
            {
                animator.Play("WalkUp");
            }
            else if (direction.y < -0.5f)
            {
                animator.Play("WalkDown");
            }
        }

        GetComponent<Rigidbody2D>().MovePosition(Vector3.MoveTowards(transform.position, nextPosition, speed));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sheep"))
        {
            nextPosition = transform.position;
        }
    }
}
