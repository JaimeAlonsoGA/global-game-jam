using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    int numberSheep = 0;

    public AudioManager sheepDelivery;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Sheep"))
            numberSheep++;
        sheepDelivery.PlaySound("event:/SheepDelivery");
        print(numberSheep);
    }
}
