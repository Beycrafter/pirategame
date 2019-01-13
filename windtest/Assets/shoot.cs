using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject cannonball;
    public Transform ctrans;
    public Vector3 temp;
    private Quaternion orientation;
    

	// Use this for initialization
	void Start () {
       // ctrans = cannonball.transform;

      //  orientation = new Quaternion(0,0,0,0);

    }
	
	// Update is called once per frame
	void Update () {
        temp = this.gameObject.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Fire!");

            GameObject clone = (GameObject)Instantiate(cannonball, new Vector3(transform.position.x, transform.position.y, transform.position.z), this.gameObject.transform.localRotation);

            

            // ctrans.position = temp;
            //   ctrans.rotation = orientation;

                if (clone.GetComponent<Rigidbody>())
                {
                    clone.GetComponent<Rigidbody>().AddRelativeForce((this.gameObject.transform.forward * 10000));   //
                }
            
        }
    }
}
