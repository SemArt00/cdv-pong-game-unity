using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{


    public Rigidbody rigidBody;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
         
            rigidBody.AddForce(Vector3.up * 20, ForceMode.Impulse);
            rigidBody.AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
        }
    }
}
