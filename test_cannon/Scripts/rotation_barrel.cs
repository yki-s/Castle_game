using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_barrel : MonoBehaviour {

    public Transform rotate_target;
    public float rotate_speed;
    public Space test_space;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rotate_target.Rotate(y * rotate_speed, 0, 0);
        rotate_target.transform.Rotate(0, x * rotate_speed, 0, test_space);
    }
}

//spaceの初期値はself