using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_force : MonoBehaviour
{
    //public float thrust;
    public float speed;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.AddForce(transform.forward + new Vector3(x * speed, 0, y * speed));

    }
}
