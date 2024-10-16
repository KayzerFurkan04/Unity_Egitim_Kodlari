using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class script : MonoBehaviour
{
    void Start()
    {
        //GetComponent<BoxCollider>().transform.position = new Vector3(1,1,1);
    }

    void Update()
    {
        //GetComponent<BoxCollider>().transform.position += new Vector3(1, 1, 1)*Time.deltaTime;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(0, 10, 0);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(0, -10, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 10);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -10);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
