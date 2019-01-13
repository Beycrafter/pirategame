using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipmove : MonoBehaviour {
    public GameObject sailobj;
    public double speeeed;
    void Start()
    {
        
    }

    public Rigidbody rigidBody;
    public GameObject ship;

    // Update is called once per frame
    void Update () {
        //speeeed = sailobj.GetComponent<sailid>().speed;
        Rotate();
        //rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime );
        //rigidBody.AddRelativeForce( ((int)speeeed * Vector3.right * Time.deltaTime *300) );   //
        ship.transform.Translate(Vector3.right *Time.deltaTime  * speedupdate(sailobj.GetComponent<sailid>().speed));

    }

private void Rotate()
{


    if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K))
    {
        print("Too many Inputs!");

    }
    else if (Input.GetKey(KeyCode.J))  //you don't want to be able to rotate both ways if pressing both a and d, however a trumps d, so if you press both down, it will rotate left
    {
        // print("Rotating Left");

        transform.Rotate(-Vector3.up * 30 * Time.deltaTime);

    }
    else if (Input.GetKey(KeyCode.K))
    {
        //   print("Rotating Right");
        transform.Rotate(Vector3.up * 30 * Time.deltaTime);
    }


}

    private int speedupdate(double speeeeeeeeeeeeed)
    {
        if(speeeeeeeeeeeeed <1)
        {
            return 1;
        }else if(speeeeeeeeeeeeed > 10){
            return 10;
        }else
        {
            return (int)speeeeeeeeeeeeed;
        }
        
    }
}
