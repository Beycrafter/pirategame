using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class sailid : MonoBehaviour {

    public GameObject sail;
    public GameObject windd;

    public double speed;
    public double sailrotation;
    public double locsailrotation;
    public Quaternion idklol;

    SerializedObject serializedObject;

    // Use this for initialization
    void Start () {
      // serializedObject = new UnityEditor.SerializedObject(transform);
       // SerializedProperty serializedEulerHint = serializedObject.FindProperty("m_LocalEulerAnglesHint");
        //Debug.Log(serializedEulerHint.vector3Value.y);
    }
	
	// Update is called once per frame
	void Update () {
        // sailrotation = this.gameObject.transform.eulerAngles.y;
        sailrotation = WrapAngle(transform.eulerAngles.y);
        locsailrotation = WrapAngle(transform.localEulerAngles.y);

        Rotate();
      //  speed = ((sail.transform.rotation.y -windd.transform.rotation.y)/ sail.transform.rotation.y) * windd.GetComponent<wind>().mag;
      //speed =(1/ Mathf.Abs(sail.transform.rotation.y - windd.transform.rotation.y)) * windd.GetComponent<wind>().mag;
        speed = (1 / Mathf.Abs(WrapAngle(sail.transform.eulerAngles.y) - WrapAngle(windd.transform.eulerAngles.y))) * windd.GetComponent<wind>().mag; // maybe use dot product
    }
    private void Rotate()
    {


        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            print("Too many Inputs!");

        }
        else if (Input.GetKey(KeyCode.U))  //you don't want to be able to rotate both ways if pressing both a and d, however a trumps d, so if you press both down, it will rotate left
        {
            // print("Rotating Left");
            if (locsailrotation > -65) {
                transform.Rotate(-Vector3.up * 20 * Time.deltaTime);
            }else
            {

            }
        }
        else if (Input.GetKey(KeyCode.I))
        {
            //   print("Rotating Right");
            if (locsailrotation < 65)
            {
                transform.Rotate(Vector3.up * 20 * Time.deltaTime);
            }else
            {

            }
        }


    }

    private static float WrapAngle(float angle)
    {
        angle %= 360;
        if (angle > 180)
            return angle - 360;

        return angle;
    }

    private static float UnwrapAngle(float angle)
    {
        if (angle >= 0)
            return angle;

        angle = -angle % 360;

        return 360 - angle;
    }


}
