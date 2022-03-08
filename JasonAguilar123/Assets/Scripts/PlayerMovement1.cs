using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    // Start is called before the first frame update

    public int moveSpeed;
    public float jumpSpeed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Input are the basic player controls
        if (Input.GetKey(KeyCode.RightArrow)) // This is for the player to move with the right Arrow Key.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right; 
        }
        if (Input.GetKey(KeyCode.LeftArrow)) // This is for the player to move with the left Arrow key. 
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow)) // This is for the player to move with the top Arrow key.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow)) // This is for the player to move with the top Arrow key.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        }
        
    }
}
