using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; //unity engine import

/*  KAYNAK DOCUMENTATION
    https://docs.unity3d.com/ScriptReference/30_search.html?q=transform
*/

//ilk script
public class MovementBehaviour : MonoBehaviour //mono behaviourdan extend oluyor
{
    //degisken atamalari burada yapilip unity editorde icerikleri ataniyor
    public float
        rotationSpeedX,
        rotationSpeedY,
        rotationSpeedZ;

    public int repeatCount;

    // 1 sec
    //Time.deltaTime; 


    // Start is called before the first frame update
    void Start() {
        repeatCount = 0;
    }

// Update is called once per frame
    void Update() {
        repeatCount++;

        if (repeatCount < 100) {
            transform.Rotate(
                rotationSpeedX,
                rotationSpeedY,
                rotationSpeedZ
            );
        }
        else {
            transform.Rotate(
                -rotationSpeedX,
                -rotationSpeedY,
                -rotationSpeedZ
            );
        }

        if (repeatCount > 200) {
            repeatCount = 0;
        }
    }
}