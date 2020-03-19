using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject characterRef;

    //3 boyutlu vector
    private Vector3 cam_characterDistance;
    
    void Start()
    {
        //transform yaratılan GameObject'e erişecek
        cam_characterDistance = transform.position - characterRef.transform.position;
    }

    //bütün updatelerden sonra yapılacak update
    private void LateUpdate()
    {
        transform.position = characterRef.transform.position + cam_characterDistance;
    }
}
