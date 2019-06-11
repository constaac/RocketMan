using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rocketBody;
    AudioSource thrusterSound;

    // Start is called before the first frame update
    void Start()
    {
        rocketBody = GetComponent<Rigidbody>();
        thrusterSound = GetComponent<AudioSource>();

        thrusterSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        if (!thrusterSound.isPlaying)
        {
            thrusterSound.Play();
        }
    }

    private void ProcessInput()
    {
        // Spacebar (Thruster) Movement
        if (Input.GetKey(KeyCode.Space))
        {
            rocketBody.AddRelativeForce(Vector3.up);
            thrusterSound.volume = 0.25F;
        } else
        {
            thrusterSound.volume = 0.08f;
        }

        // A | D Movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back);
        }


        // W | S Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left);
        }
    }
}
