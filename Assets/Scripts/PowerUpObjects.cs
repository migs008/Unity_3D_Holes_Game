/*  PowerUpObjects controlls the movement (bounce and spin) of both the speedBoost and speedSlow game
 *  objects as well as the coins
 *
 *  CS 583 Fall 2021
 *  12/3/21
 *  @author Alexander Kuzdal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpObjects : MonoBehaviour
{

    public float turnSpeed = 90f;
    public AnimationCurve myCurve;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }
}
