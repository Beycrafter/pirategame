using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestruct : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.tag)
        {
            case "water":
                {
                  //  print("water");
                    Destroy(this.gameObject, 1.0f);
                    break;
                }
            case "target":
                {
                    //  print("water");
                    Destroy(this.gameObject, 0.0f);
                    break;
                }
            default:
                {
                    //  print("Dead");
                    Destroy(this.gameObject, 10.0f);
                    break;
                }
        }

    }

}


