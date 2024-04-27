using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //initialize all variable
    private float speed = 15.0f;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame updatew
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get input controll (forward backward and turn left/right)
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //move the vehicle forward/backward by press the vertical button
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //move the vehicle right/left by press the horizontal button
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

}
