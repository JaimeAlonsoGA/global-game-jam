using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliff : MonoBehaviour
{
    public AudioManager sheepFallSound; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Sheep"))
        {
            Destroy(col.gameObject);
            sheepFallSound.PlaySound("event:/SheepFall");
        }
    }
}
