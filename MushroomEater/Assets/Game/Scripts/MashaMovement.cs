using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashaMovement : MonoBehaviour
{

    private Rigidbody2D rb2d;
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        
    }

    private void Update()
    {
        MoveHorizontal();
    }

    private void MoveHorizontal()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");

        rb2d.MovePosition(horizontal * Vector3.right);

    }
    
    
}
