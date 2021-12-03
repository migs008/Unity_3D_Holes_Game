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

    private GameManager gameManager;

    public float playerSpeed;
    public Rigidbody playerRb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    private float boostTimer;
    private bool boosting;

    private bool isDead = false;

    void Start() {
        gameManager = GameManager.Instance;
        setSpeed();

        boostTimer = 0;
        boosting = false;

    }

    void FixedUpdate() {

        if (isDead)
            return;

        Vector3 forwardMove = transform.forward * playerSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * playerSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        playerRb.MovePosition(playerRb.position + forwardMove + horizontalMove);

        if (boosting) {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 3) {
                setSpeed();
                boostTimer = 0;
                boosting = false;
            }
        }
    }

    // Update is called once per frame
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void setSpeed() {
        string selectedDifficulty = GameManager.Instance.currentPlayerData.Difficulty;
        if (selectedDifficulty == "Easy") {
            playerSpeed = 5;
        }
        else if (selectedDifficulty == "Medium") {
            playerSpeed = 7;
        }
        else if (selectedDifficulty == "Hard") {
            playerSpeed = 10;
        }
        else {
            playerSpeed = 5;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
            Death();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpeedSlow") {
            other.gameObject.SetActive(false);
            boosting = true;
            playerSpeed = playerSpeed / 2;
        }
        if (other.gameObject.tag == "SpeedBoost") {
            other.gameObject.SetActive(false);
            boosting = true;
            playerSpeed = playerSpeed * 2;
        }

    }


    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
