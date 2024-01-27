using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour
{
    public List<GameObject> sheep = new();
    public float wolfSpeed;
    private Transform target;
    Animator animator;
    SpriteRenderer spriteRenderer;
    public AudioManager wolfSound;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorClipInfo(0).Length > 0 && animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Attack")
            return;

        SearchSheep();
    }

    void SearchSheep()
    {
        target = FindTarget();
        if (target != null)
        {
            Vector3 direction = Vector3.Normalize(target.position - transform.position);
            GetComponent<Rigidbody2D>().MovePosition(transform.position + direction * wolfSpeed * Time.deltaTime);
            PlayMoveAnimation(direction);
        }
    }

    public Transform FindTarget()
    {
        GameObject[] sheep = GameObject.FindGameObjectsWithTag("Sheep");
        float minDistance = Mathf.Infinity;
        Transform closest;
        float distance;

        if (sheep.Length > 0)
            closest = sheep[0].transform;
        else
            return transform;

        for (int i = 0; i < sheep.Length; ++i)
        {
            distance = Vector3.Distance(sheep[i].transform.position, transform.position);
            if (distance < minDistance)
            {
                closest = sheep[i].transform;
                minDistance = distance;
            }
        }

        return closest;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sheep")
        {
            Destroy(collision.gameObject);
            target = null;
            animator.Play("Attack");
            StartCoroutine(KillSheep());
            wolfSound.PlaySound("event:/WolfKillsSheep");
        }
    }

    IEnumerator KillSheep()
    {
        yield return new WaitForSeconds(2f);
        SearchSheep();
    }

    void PlayMoveAnimation(Vector3 direction)
    {
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
}


