using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject vehicle;
    private Vector3 offset = new Vector3(0, 5.5f, -20);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the camera by adding to the player's position
        transform.position = vehicle.transform.position + offset;
    }
}
