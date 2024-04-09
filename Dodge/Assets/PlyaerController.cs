using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f; //이동 속력
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        /**
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        **/

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xspeed = xInput * speed;
        float zspeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xspeed, 0f, zspeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
