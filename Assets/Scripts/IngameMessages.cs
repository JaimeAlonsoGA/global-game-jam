using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class IngameMessages : MonoBehaviour
{
    public SafeArea SafeArea;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if((float)SafeArea.numberSheepInside / (float)SafeArea.totalSheep >= 0.5f)
        {
            text.enabled = true;
        }
    }
}
