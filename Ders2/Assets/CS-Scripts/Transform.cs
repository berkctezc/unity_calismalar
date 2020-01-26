using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public float
        SpeedX,
        SpeedY,
        SpeedZ;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            SpeedX*Time.deltaTime,
            SpeedY*Time.deltaTime,
            SpeedZ*Time.deltaTime);
    }
}
