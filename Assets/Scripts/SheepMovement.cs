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

    // Start is called before the first frame update
    void Start()
    {
        timeToNextAction = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        currentTimeToNextAction += Time.deltaTime;
        if(currentTimeToNextAction >= timeToNextAction)
        {
            timeToNextAction = Random.Range(5f, 10f);
            currentTimeToNextAction = 0f;
            nextPosition = transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        }

        scapePosition = Vector3.zero;
        if(Vector3.Distance(shepherds[0].transform.position, transform.position) < 3f)
        {
            scapePosition += transform.position - shepherds[0].transform.position;
        }
        if(Vector3.Distance(shepherds[1].transform.position, transform.position) < 3f)
        {
            scapePosition += transform.position - shepherds[1].transform.position;
        }
        if(scapePosition != Vector3.zero)
            nextPosition = Vector3.Normalize(scapePosition) * 10f;

        GetComponent<Rigidbody2D>().MovePosition(Vector3.MoveTowards(transform.position, nextPosition, speed));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Sheep"))
        {
            nextPosition = transform.position;
        }
    }
}
