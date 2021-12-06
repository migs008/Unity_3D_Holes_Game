using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotator : MonoBehaviour
{
    [SerializeField] float xAngle, yAngle, zAngle;
    public AudioClip shuffleSound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Rotates the model
            transform.Rotate(xAngle, yAngle, zAngle, Space.World);
            AudioSource.PlayClipAtPoint(shuffleSound, transform.position);
        }
    }
}
