using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour {

    public double mag;
    public double direction;

    void Start()
    {
        
    }

    void Update()
    {
        direction = this.gameObject.transform.localEulerAngles.y;
        Rotate();
    }

    private void Rotate()
    {


        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            print("Too many Inputs!");

        }
        else if (Input.GetKey(KeyCode.LeftArrow))  //you don't want to be able to rotate both ways if pressing both a and d, however a trumps d, so if you press both down, it will rotate left
        {
            // print("Rotating Left");
           
            transform.Rotate(-Vector3.up * 20 * Time.deltaTime);
        
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //   print("Rotating Right");
            transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        }


    }
}
