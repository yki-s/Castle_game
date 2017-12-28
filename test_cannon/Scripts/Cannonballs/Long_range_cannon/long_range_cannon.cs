using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class long_range_cannon : MonoBehaviour {

    public GameObject bullet;
    public Transform barrel;
    public Transform fire_center;
    public float speed;
    public GameObject parentObject;
    Vector3 shoot_angle;
    public Vector3 force;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        shoot_angle = barrel.position - fire_center.position;
        force = shoot_angle * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullets = GameObject.Instantiate(bullet, gameObject.transform) as GameObject;
            bullets.transform.parent = parentObject.transform;
            bullets.GetComponent<Rigidbody>().AddForce(force);
        }
		
	}
}
