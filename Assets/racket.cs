using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour{
    public float speed = 150;
    void FixedUpdate () {
        float horizontal = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontal * speed;
    }
}
