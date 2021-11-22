using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float playerSpeed = 5;
    public Rigidbody playerRb;

    void FixedUpdate() {
        Vector3 forwardMove = transform.forward * playerSpeed * Time.fixedDeltaTime;
        playerRb.MovePosition(playerRb.position + forwardMove);
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
