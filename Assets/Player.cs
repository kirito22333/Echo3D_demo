using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int speed = 10;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        float zSpeed = Input.GetAxis("Vertical") * speed;
        _rigidbody.AddForce(new Vector3(xSpeed, 0, zSpeed));
    }
}
