using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setpos : MonoBehaviour {
    public GameObject objfollowing;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = new Vector3(objfollowing.transform.position.x , objfollowing.transform.position.y + 1.8f, objfollowing.transform.position.z - 0.1389999f);
		
	}
}
