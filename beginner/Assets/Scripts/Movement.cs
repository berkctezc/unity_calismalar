using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float speedX=-500, speedY=0, speedZ=0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World"); //print in unity editor console
        //rb.useGravity = false;
    }

    // using it instead of Update because, framerate may vary
    void FixedUpdate()
    {
        rb.AddForce(speedX * Time.deltaTime, speedY, speedZ);
    }
}
