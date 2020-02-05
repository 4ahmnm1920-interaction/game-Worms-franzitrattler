using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 jump;
    public Vector3 left;
    public Vector3 right;

    public KeyCode shootKey;


    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(jump);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(left);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            rb.AddForce(right);
        }


        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("boom");
        }
    }

}
