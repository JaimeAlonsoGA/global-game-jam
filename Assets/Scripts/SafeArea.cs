using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    public int totalSheep = 0;
    public int numberSheepInside = 0;
    public AudioManager sheepSafeSound;

    HashSet<GameObject> sheep = new HashSet<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        totalSheep = GameObject.FindGameObjectsWithTag("Sheep").Length;
    }

    // Update is called once per frame
    void Update()
    {
        totalSheep = GameObject.FindGameObjectsWithTag("Sheep").Length;
        numberSheepInside = sheep.Count;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Sheep"))
            sheep.Add(col.gameObject);
        sheepSafeSound.PlaySound("event:/SheepDelivery");
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Sheep"))
            sheep.Remove(col.gameObject);
    }
}
