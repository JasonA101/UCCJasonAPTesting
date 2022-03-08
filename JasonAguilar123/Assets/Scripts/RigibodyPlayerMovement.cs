using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyPlayerMovement : MonoBehaviour
{


    // public float move speed;
    // private Rigibody rigibody;*/

    public float moveSpeed;
    private new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigidbody.velocity.y, Input.GetAxis("Vertical")) * moveSpeed;
        Debug.Log("Currently detecting" + rigidbody);
    }
}
