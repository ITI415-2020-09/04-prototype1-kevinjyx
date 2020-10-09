using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private const float JUMP_AMOUNT = 100f;
    private Rigidbody birdrigidbody;
    private void Awake()
    {
       birdrigidbody = GetComponent<Rigidbody>();
    }

        private void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
 
    private void Jump()
    {
        birdrigidbody.velocity= Vector2.up * JUMP_AMOUNT;
    }

}
