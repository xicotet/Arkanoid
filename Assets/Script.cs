using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour{
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        Destroy(gameObject);
    }
}
