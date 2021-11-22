/*  PlayerMovement sets the speed of the player to 5 to constantly move forward. The player can move
 *  horizontally with a multiplier of 2 so the user can navigate obstacles.
 *
 *  CS 583 Fall 2021
 *  11/21/21
 *  @author Alexander Kuzdal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float playerSpeed = 5;
    public Rigidbody playerRb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    void FixedUpdate() {
        Vector3 forwardMove = transform.forward * playerSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * playerSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        playerRb.MovePosition(playerRb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
