using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_long_range_cannon : MonoBehaviour {

    public GameObject bullet;
    public GameObject pointer;
    public GameObject parent_pointers;
    List<GameObject> pointerList;
    float mass;
    public long_range_cannon shoot;
    public int dummyCount;
    Vector3 force;
    float[] deltatimeList;

	// Use this for initialization
	void Start () {
        pointerList = new List<GameObject>();
        deltatimeList = new float[dummyCount];

        for (int i = 0; i < dummyCount; i++)
        {
            GameObject pointer_clone = GameObject.Instantiate(pointer);
            pointer_clone.transform.parent = parent_pointers.transform;
            pointerList.Add(pointer_clone);

            deltatimeList[i] = (float) (i+1) / 3;
        }

        mass = bullet.GetComponent<Rigidbody>().mass;
    }

    // Update is called once per frame
    void Update () {
        force = shoot.force;

        for (int i = 0; i < dummyCount; i++)
        {
            float deltatime = deltatimeList[i];
            GameObject one_pointer = pointerList[i];
            one_pointer.transform.localPosition = Calctrack(mass, force, deltatime);
        }
	}

    Vector3 Calctrack(float mass, Vector3 force, float time)
    {
        Vector3 speed = (force / mass) * Time.fixedDeltaTime;
        Vector3 position = (speed * time) + (Physics.gravity * 0.5f * Mathf.Pow(time, 2));

        return position;
    }
}
