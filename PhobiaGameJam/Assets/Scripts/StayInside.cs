using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6f, 6f),
            Mathf.Clamp(transform.position.y, -4f, 0f), transform.position.z);
	}
}
