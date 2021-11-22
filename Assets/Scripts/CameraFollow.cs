/*  CameraFollow takes the player and sets the offset of the camera from the player as the player moves.
 *  The position on the x axis stays solid as the player moves left and right.
 *
 *  CS 583 Fall 2021
 *  11/21/21
 *  @author Alexander Kuzdal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start() {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update() {
        Vector3 targetPosition = transform.position = player.position + offset;
        targetPosition.x = 0;
        transform.position = targetPosition;
    }
}
