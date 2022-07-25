using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPaused : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Is Paused "+ (Time.timeScale== 0) + " time scale: " + Time.timeScale);
    }
}
