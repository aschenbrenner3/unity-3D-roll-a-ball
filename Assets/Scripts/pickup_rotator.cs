using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame - use over FixedUpdate when not using forces
	void Update () {
		transform.Rotate ( new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
