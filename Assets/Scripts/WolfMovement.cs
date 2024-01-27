using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour
{
    public GameObject[] sheep = new GameObject[2];
    public float wolfSpeed;
    private Transform target;

    public Transform FindTarget()
    {
        GameObject[] sheep = GameObject.FindGameObjectsWithTag("Sheep");
        float minDistance = Mathf.Infinity;
        Transform closest;
        float distance;

        closest = sheep[0].transform;

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



    // Start is called before the first frame update
    void Start()
    {
        // sheep = GameObject.FindGameObjectsWithTag("Sheep");
        
    }

    // Update is called once per frame
    void Update()
    {
        target = FindTarget();
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().MovePosition(transform.position + direction * wolfSpeed * Time.deltaTime);
        }

        // transform.position = (Vector3.Distance(transform.position, sheep[0].transform.position) > 1) ? Vector3.MoveTowards(transform.position, sheep.transform.position, wolfSpeed * Time.deltaTime) : transform.position;
        // Vector3 direction = Sheep.transform.position - transform.position;

    }
}


