using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Castle : MonoBehaviour
{
    //public float thrust;
    public float force;

    void Start()
    {
    }

    void FixedUpdate()
    {
        float y = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");

        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x * force, 0, -y * force));

    }
}
